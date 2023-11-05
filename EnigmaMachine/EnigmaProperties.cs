using System.Diagnostics;

namespace EnigmaMachine
{
    public partial class EnigmaProperties : Form
    {

        public event EventHandler<List<RotorInfo>> ListChanged;

        public EnigmaProperties(List<RotorInfo> rotorInfo)
        {
            InitializeComponent();
            DarkTheme();
            FillInfo(rotorInfo);
        }

        private void DarkTheme()
        {
            BackColor = Color.FromArgb(109, 118, 143);
        }

        private void FillInfo(List<RotorInfo> infos)
        {
            dgvRotors.AllowUserToAddRows = false;

            dgvRotors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRotors.Columns.Add("Wiring", "Wiring");
            dgvRotors.Columns[0].FillWeight = 120f;

            dgvRotors.Columns.Add("Initial Offset", "Initial Offset");

            dgvRotors.Columns.Add("Notch Position", "Notch Position");

            foreach (var info in infos)
            {
                dgvRotors.Rows.Add(info.Wiring, info.InitialOffset, info.NotchPosition);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvRotors.Rows.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 0, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<RotorInfo> infos = new List<RotorInfo>();
            foreach (DataGridViewRow info in dgvRotors.Rows)
            {
                Debug.WriteLine(info.Cells[0].Value);
                RotorInfo rotorInfo = new RotorInfo((string)info.Cells[0].Value, (int)info.Cells[1].Value, (int)info.Cells[2].Value);
                infos.Add(rotorInfo);
            }

            ListChanged?.Invoke(this, infos);
            this.Close();
        }
    }
}
