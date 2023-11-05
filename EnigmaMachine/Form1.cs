using System.Diagnostics;

namespace EnigmaMachine
{
    public partial class Form1 : Form
    {
        private EnigmaMachine _enimgaMachine = new EnigmaMachine();

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            OnResize(new EventArgs());
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            int availableHeight = this.Bounds.Height - pnlProperties.Bounds.Height - 50;
            int heightPerPanel = availableHeight / 2;

            pnlInput.Height = heightPerPanel;
            pnlOutput.Location = new Point(0, pnlInput.Bounds.Bottom);
            pnlOutput.Height = heightPerPanel;
            pnlProperties.Location = new Point(0, pnlOutput.Bounds.Bottom);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ProcessText();
        }

        private void ProcessText()
        {
            //_enimgaMachine.BindPlugBoardCharacters('A', 'G');

            string outputText = string.Empty;

            if (rbtEncrypt.Checked)
            {
                outputText += _enimgaMachine.Encrypt(tbxInput.Text);
            }
            else
            {
                outputText += _enimgaMachine.Decrypt(tbxInput.Text);
            }

            tbxOutput.Text = outputText;
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

        private void tbxInput_TextChanged(object sender, EventArgs e)
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
        }
    }
}