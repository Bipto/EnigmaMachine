using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Dictionary<char, ComboBox> _plugCombos;

        public Form1()
        {
            InitializeComponent();
            RtbContent.Enabled = false;
            RtbOutput.Enabled = false;
            RtbOutput.ReadOnly = true;
            BtnReset.Enabled = false;
            CreatePlugList();
            ResetPlugs();
            DisablePlugs();
            BtnConfigure.Enabled = false;
            BtnEncode.Enabled = false;
        }

        private void CreatePlugList()
        {
            _plugCombos = new Dictionary<char, ComboBox>();
            _plugCombos.Add('A', CbxPlugA);
            _plugCombos.Add('B', CbxPlugB);
            _plugCombos.Add('C', CbxPlugC);
            _plugCombos.Add('D', CbxPlugD); 
            _plugCombos.Add('E', CbxPlugE);
            _plugCombos.Add('F', CbxPlugF);
            _plugCombos.Add('G', CbxPlugG);
            _plugCombos.Add('H', CbxPlugH);
            _plugCombos.Add('I', CbxPlugI);
            _plugCombos.Add('J', CbxPlugJ);
            _plugCombos.Add('K', CbxPlugK);
            _plugCombos.Add('L', CbxPlugL);
            _plugCombos.Add('M', CbxPlugM);
            _plugCombos.Add('N', CbxPlugN);
            _plugCombos.Add('O', CbxPlugO);
            _plugCombos.Add('P', CbxPlugP);
            _plugCombos.Add('Q', CbxPlugQ);
            _plugCombos.Add('R', CbxPlugR);
            _plugCombos.Add('S', CbxPlugS);
            _plugCombos.Add('T', CbxPlugT);
            _plugCombos.Add('U', CbxPlugU);
            _plugCombos.Add('V', CbxPlugV);
            _plugCombos.Add('W', CbxPlugW);
            _plugCombos.Add('X', CbxPlugX);
            _plugCombos.Add('Y', CbxPlugY);
            _plugCombos.Add('Z', CbxPlugZ);
        }

        private void ResetPlugs()
        {
            foreach (var combo in _plugCombos)
            {
                combo.Value.SelectedIndex = 0;
            }
        }

        private void DisablePlugs()
        {
            foreach (var combo in _plugCombos)
            {
                combo.Value.Enabled = false;
            }
        }

        private void EnablePlugs()
        {
            foreach (var combo in _plugCombos)
            {
                 combo.Value.Enabled = true;
            }
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

                    EnablePlugs();
                    BtnConfigure.Enabled = true;
                    return;
                }
            }

            RtbContent.Enabled = false;
            RtbOutput.Enabled = false;
            BtnReset.Enabled = false;
            DisablePlugs();
            BtnConfigure.Enabled = false;
            BtnEncode.Enabled = false;
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

        private void BtnConfigure_Click(object sender, EventArgs e)
        {
            Dictionary<char, char> plugs = new Dictionary<char, char>();

            foreach (var combo in _plugCombos)
            {
                if (combo.Value.SelectedIndex != 0)
                {
                    string text = combo.Value.GetItemText(combo.Value.SelectedItem);
                    char value = text[0];
                    plugs.Add(combo.Key, value);
                }
            }

            _enigmaMachine.CreatePlugboard(plugs);

            RtbContent.Enabled = true;
            RtbOutput.Enabled = true;
            BtnReset.Enabled = true;
            BtnEncode.Enabled = true;
        }
    }
}
