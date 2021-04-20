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

        private Rotor[] _rotors = new Rotor[3];
        private Plugboard _plugboard;

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
                    continue;
                }                

                else
                {
                    char character;
                    char finalCharacter;

                    if (_rotors[0].TurnRotor())
                    {
                        int value1 = _rotors[0].GetOutput();
                        if (_rotors[1].TurnRotor())
                        {
                            int value2 = _rotors[1].GetOutput(value1);                            
                            if (_rotors[2].TurnRotor())
                            {
                                int value3 = _rotors[2].GetOutput(value2);
                                character = Rotor.ConvertIndexToCharacter(value3);
                                finalCharacter = _plugboard.GetFinalCharacter(character);
                                outputText += character;
                            }

                            else
                            {
                                character = Rotor.ConvertIndexToCharacter(value2);
                                finalCharacter = _plugboard.GetFinalCharacter(character);
                                outputText += character;
                            }
                        }

                        else
                        {
                            character = Rotor.ConvertIndexToCharacter(value1);
                            finalCharacter = _plugboard.GetFinalCharacter(character);
                            outputText += character;
                        }
                    }

                    else
                    {
                        character = Rotor.ConvertIndexToCharacter(_rotors[0].GetOutput());
                        finalCharacter = _plugboard.GetFinalCharacter(character);
                        outputText += character;
                    }                    
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
        }

        public void CreatePlugboard(Dictionary<char, char> plugs)
        {
            _plugboard = new Plugboard(plugs);
        }
    }
}
