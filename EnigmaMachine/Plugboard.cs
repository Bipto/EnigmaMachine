using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    public class Plugboard
    {
        private Dictionary<char, char> _mapping;

        public Plugboard(Dictionary<char, char> map)
        {
            _mapping = map;
            Debug.WriteLine("Plugboard created");
        }

        public char GetFinalCharacter(char input)
        {
            foreach (var pair in _mapping)
            {
                if (pair.Key == input)
                {
                    return pair.Value;
                }
            }

            return input;
        }        
    }
}
