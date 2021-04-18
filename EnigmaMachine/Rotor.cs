using System;
using System.Collections.Generic;
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

        public void Reset()
        {
            _rotorPosition = _startingPosition;
        }
    }
}
