using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EnigmaMachine.EnigmaMachine;

namespace EnigmaMachine
{
    public partial class Form1 : Form
    {
        private EnigmaMachine _enigmaMachine;

        public Form1()
        {
            InitializeComponent();
            RtbContent.Enabled = false;
            RtbOutput.Enabled = false;
            RtbOutput.ReadOnly = true;
            BtnReset.Enabled = false;
        }

        private RotorName CreateRotor(string value)
        {
           if (value == "I")
           {
                return RotorName.I;
           }
           else if (value == "II")
           {
                return RotorName.II;
           }
           else if (value == "III")
           {
                return RotorName.III;
           }
           else if (value == "IV")
           {
                return RotorName.IV;
           }

           else if (value == "V")
           {
                return RotorName.V;
           }
           else if (value == "VI")
           {
                return RotorName.VI;
           }
           else if (value == "VII")
           {
                return RotorName.VII;
           }
            else
           {
                return RotorName.VIII;
           }

        }

        private void CheckConfiguration()
        {
            if ((CbxRotor1.Text.Length != 0) && (CbxRotor2.Text.Length != 0))
            {
                if ((CbxRotor1.Text == CbxRotor2.Text))
                {
                    MessageBox.Show("Rotors 1 and 2 cannot match!");
                }
            }

            if ((CbxRotor2.Text.Length != 0) && (CbxRotor3.Text.Length != 0))
            {
                if ((CbxRotor2.Text == CbxRotor3.Text))
                {
                    MessageBox.Show("Rotors 2 and 3 cannot match!");
                }
            }

            if ((CbxRotor1.Text.Length != 0) && (CbxRotor3.Text.Length != 0))
            {
                if (CbxRotor1.Text == CbxRotor3.Text)
                {
                    MessageBox.Show("Rotors 1 and 3 cannot match!");
                }
            }

            if ((CbxRotor1.Text.Length != 0) && (CbxRotor2.Text.Length != 0) && (CbxRotor3.Text.Length != 0))
            {             
                if ((CbxStartPos1.Text.Length != 0) && (CbxStartPos2.Text.Length != 0) && (CbxStartPos3.Text.Length != 0))
                {
                    RotorName rotor1 = CreateRotor(CbxRotor1.Text);
                    RotorName rotor2 = CreateRotor(CbxRotor2.Text);
                    RotorName rotor3 = CreateRotor(CbxRotor3.Text);
                    
                    int startPos1 = int.Parse(CbxStartPos1.Text);
                    int startPos2 = int.Parse(CbxStartPos2.Text);
                    int startPos3 = int.Parse(CbxStartPos3.Text);

                    _enigmaMachine = new EnigmaMachine(new[] { rotor1, rotor2, rotor3 }, new[] { startPos1, startPos2, startPos3 });

                    RtbContent.Enabled = true;
                    RtbOutput.Enabled = true;
                    BtnReset.Enabled = true;
                    return;
                }
            }

            RtbContent.Enabled = false;
            RtbOutput.Enabled = false;
            BtnReset.Enabled = false;
        }

        private void CbxRotor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }

        private void CbxRotor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }

        private void CbxRotor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }

        private void CbxStartPos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }        

        private void CbxStartPos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }

        private void CbxStartPos3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckConfiguration();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _enigmaMachine.Reset();
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            string output = _enigmaMachine.EncryptMessage(RtbContent.Text);
            RtbOutput.Text = output;
        }
    }
}
