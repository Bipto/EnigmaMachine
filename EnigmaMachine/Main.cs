namespace EnigmaMachine
{
    public partial class Main : Form
    {
        private EnigmaMachine _enimgaMachine = new EnigmaMachine();

        private const string _configPath = "enigma.config";

        public Main()
        {
            InitializeComponent();
            Resize += Form1_Resize;
            OnResize(new EventArgs());
            DarkTheme();
            this.FormClosed += Main_FormClosed;

            if (File.Exists(_configPath))
            {
                _enimgaMachine = EnigmaMachine.LoadFromFile(_configPath);
            }
            else
            {
                _enimgaMachine = EnigmaMachine.Default;
            }
        }

        private void Main_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _enimgaMachine.SaveConfig(_configPath);
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            int availableHeight = Bounds.Height - (pnlInputTitle.Bounds.Height);
            int heightPerPanel = availableHeight / 2;

            pnlInput.Location = new Point(0, 0);
            pnlInput.Size = new Size(Bounds.Width, heightPerPanel - pnlOutputTitle.Bounds.Height);

            pnlOutput.Location = new Point(0, pnlInput.Bounds.Bottom - pnlOutputTitle.Bounds.Height);
            pnlOutput.Size = new Size(Bounds.Width, heightPerPanel);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private string ProcessText(string input)
        {
            string outputText = string.Empty;

            if (rbtEncrypt.Checked)
            {
                outputText += _enimgaMachine.Encrypt(input);
            }
            else
            {
                outputText += _enimgaMachine.Decrypt(input);
            }

            return outputText;
        }

        private char ApplyCaesarCipher(char character, int incrementAmount = 5)
        {
            int minValue = 'A';
            int maxValue = 'Z';

            int c = character;
            c += incrementAmount;

            if (c > maxValue)
            {
                int overflow = c - maxValue;
                c = minValue + overflow;
            }

            else if (c < minValue)
            {
                int underflow = minValue - c;
                c = maxValue - underflow;
            }


            return (char)c;
        }

        private void LightTheme()
        {

        }

        private void DarkTheme()
        {
            BackColor = Color.FromArgb(109, 118, 143);

            pnlInputContent.BackColor = Color.FromArgb(134, 142, 167);
            pnlInputContent.BorderStyle = BorderStyle.None;

            tbxInput.BackColor = Color.FromArgb(134, 142, 167);
            tbxInput.BorderStyle = BorderStyle.None;

            tbxOutput.BackColor = Color.FromArgb(134, 142, 167);
            tbxOutput.BorderStyle = BorderStyle.None;

            menuStrip1.BackColor = Color.FromArgb(99, 108, 133);
            menuStrip1.RenderMode = ToolStripRenderMode.System;

            fileToolStripMenuItem.DropDown.BackColor = Color.FromArgb(99, 108, 133);
            fileToolStripMenuItem.BackColor = Color.FromArgb(99, 108, 133);

            propertiesToolStripMenuItem.DropDown.BackColor = Color.FromArgb(99, 108, 133);
            propertiesToolStripMenuItem.BackColor = Color.FromArgb(99, 108, 133);

            menuStrip1.Renderer = new CustomToolStripRenderer();
        }

        private void tbxInput_TextChanged_1(object sender, EventArgs e)
        {
            string output = string.Empty;
            foreach (char c in tbxInput.Text)
            {
                if (char.IsLetter(c))
                {
                    output += char.ToUpper(c);
                }
            }
            tbxInput.Text = output;
            tbxInput.SelectionStart = tbxInput.Text.Length;
            tbxInput.SelectionLength = 1;

            tbxOutput.Text = ProcessText(tbxInput.Text);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = new EnigmaProperties(_enimgaMachine.GetRotorInformation());
            popup.ListChanged += Popup_ListChanged;
            popup.ShowDialog();
        }

        private void Popup_ListChanged(object? sender, List<RotorInfo> e)
        {
            _enimgaMachine.Rotors.Clear();

            List<RotorInfo> rotorInfos = new List<RotorInfo>();
            foreach (var info in e)
            {
                _enimgaMachine.Rotors.Add(new Rotor(info));
            }
        }
    }

    class CustomToolStripRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }
    }
}