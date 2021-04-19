using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnigmaMachine.EnigmaMachine;

namespace EnigmaMachine
{
    public class Rotor
    {
        private RotorName _name;
        private int _startingPosition;
        private int _rotorPosition;
        private int[] _turnoverPositions;

        public static readonly Dictionary<int, char> _characterMap = new Dictionary<int, char>()
        {
            {1, 'A'}, {2, 'B'}, { 3, 'C'}, {4,'D'}, {5, 'E'}, {6, 'F'}, {7, 'G'}, {8, 'H'}, {9, 'I'}, {10, 'J'}, {11, 'K'}, {12, 'L'}, {13, 'M'}, {14, 'N'}, {15, 'O'}, {16, 'P'}, {17, 'Q'}, {18, 'R'}, {19, 'S'}, {20, 'T'}, {21, 'U'}, {22, 'V'}, {23, 'W'}, {24, 'X'}, {25, 'Y'}, {26, 'Z'}
        };

        public char CurrentChar
        {
            get 
            {
                char character;
                _characterMap.TryGetValue(_rotorPosition, out character);
                return character;
            }
        }

        public Rotor(RotorName name, int startingPosition)
        {
            _name = name;
            _startingPosition = startingPosition;
            _rotorPosition = startingPosition;
            _turnoverPositions = CalculateTurnoverPositions(_name);
        }

        private int[] CalculateTurnoverPositions(RotorName name)
        {
            if (_name == RotorName.I)
            {
                return new[] { 18 };
            }            

            else if (_name == RotorName.II)
            {
                return new[] { 6 };
            }

            else if (_name == RotorName.III)
            {
                return new[] { 23 };
            }

            else if (_name == RotorName.IV)
            {
                return new[] { 11 };
            }

            else if (_name == RotorName.V)
            {
                return new[] { 1 };
            }

            else
            {
                return new[] { 1, 14 };
            }
        }

        public bool TurnRotor()
        {
            if (_rotorPosition < 26)
            {
                _rotorPosition++;
                return CheckIfTurnedOver();                
            }

            else
            {
                _rotorPosition = 1;
                return CheckIfTurnedOver();
            }            
        }

        private bool CheckIfTurnedOver()
        {
            foreach (int turnover in _turnoverPositions)
            {
                if (turnover == _rotorPosition)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetOutput(int input = 0)
        {
            if (input == 0)
            {
                input = _rotorPosition;
            }

            int output = input;

            for (int i = 0; i < input; i++)
            {
                output++;
                if (output == 26)
                {
                    output = 1;
                }
            }

            return output;
        }

        public static char ConvertIndexToCharacter(int index)
        {
            char character;
            _characterMap.TryGetValue(index, out character);
            Debug.WriteLine(character);
            return character;
        }

        public void Reset()
        {
            _rotorPosition = _startingPosition;
        }
    }
}
