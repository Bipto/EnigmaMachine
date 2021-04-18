using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public class EnigmaMachine
    {
        public enum RotorName
        {
            I,
            II,
            III,
            IV,
            V,
            VI,
            VII,
            VIII
        }

        private readonly Dictionary<int, char> _characterMap = new Dictionary<int, char>()
        {
            {1, 'A'}, {2, 'B'}, { 3, 'C'}, {4,'D'}, {5, 'E'}, {6, 'F'}, {7, 'G'}, {8, 'H'}, {9, 'I'}, {10, 'J'}, {11, 'K'}, {12, 'L'}, {13, 'M'}, {14, 'N'}, {15, 'O'}, {16, 'P'}, {17, 'Q'}, {18, 'R'}, {19, 'S'}, {20, 'T'}, {21, 'U'}, {22, 'V'}, {23, 'W'}, {24, 'X'}, {25, 'Y'}, {26, 'Z'} 
        };

        private Rotor[] _rotors = new Rotor[3];

        public EnigmaMachine(RotorName[] rotors, int[] startingPoints)
        {
            _rotors[0] = new Rotor(rotors[0], startingPoints[0]);        
            _rotors[1] = new Rotor(rotors[1], startingPoints[1]);        
            _rotors[2] = new Rotor(rotors[2], startingPoints[2]);        
        }   
        
        public string EncryptMessage(string message)
        {
            string textToProcess = message.ToUpper();
            string outputText = "";

            foreach (char value in textToProcess)
            {
                if (value == ' ')
                {
                    outputText += ' ';
                }

                else
                {
                    outputText += value;
                }
            }

            return outputText;
        }

        public void Reset()
        {
            foreach (Rotor rotor in _rotors)
            {
                rotor.Reset();
            }

            MessageBox.Show("The rotors have been reset.");
        }
    }
}
