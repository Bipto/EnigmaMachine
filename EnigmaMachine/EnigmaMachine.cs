using System.Diagnostics;

namespace EnigmaMachine
{
    internal class EnigmaMachine
    {
        internal PlugBoard _plugboard = new PlugBoard();

        List<Rotor> _rotors = new List<Rotor>();

        public EnigmaMachine()
        {
            _rotors.Add(new Rotor("DMTWSILRUYQNKFEJCAZBPGXOHV", 24, 25));
            _rotors.Add(new Rotor("HQZGPJTMOBLNCIFDYAWVEUSRKX", 0, 4));
            _rotors.Add(new Rotor("UQNTLSZFMREHDPXKIBVYGJCWOA", 12, 18));

            _plugboard.BindCharacters('F', 'Z');
        }

        public void RemovePlugs()
        {
            _plugboard.Reset();
        }

        private void Reset()
        {
            foreach (Rotor rotor in _rotors)
            {
                rotor.Reset();
            }
        }

        public string Encrypt(string text)
        {
            Reset();

            string output = string.Empty;

            //processing
            {
                foreach (char character in text)
                {
                    output += Encrypt(character);
                }
            }
            
            return output;
        }

        public string Decrypt(string text)
        {
            Reset();

            string output = string.Empty;

            //processing
            {
                foreach (char character in text)
                {
                    output += Decrypt(character);
                }
            }
            
            return output;
        }

        private char Encrypt(char character)
        {
            char output = char.ToUpper(character);
            RotateRotor();

            //character goes through the plugboard for the first time
            output = _plugboard.Replace(output);

            //character goes through each rotor forward
            for (int i = 0; i < _rotors.Count; i++)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Encrypt(output);
            }

            //character goes through each rotor backwards
            for (int i = _rotors.Count - 1; i >= 0; i--)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Encrypt(output);
            }

            //character goes through the plugboard for the second time
            output = _plugboard.Replace(output);

            return output;
        }

        private char Decrypt(char character)
        {
            char output = char.ToUpper(character);
            RotateRotor();

            //character goes through the plugboard for the first time
            output = _plugboard.Replace(output);

            //character goes through each rotor forward
            for (int i = 0; i < _rotors.Count; i++)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Decrypt(output);
            }

            //character goes through each rotor backwards
            for (int i = _rotors.Count - 1; i >= 0; i--)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Decrypt(output);
            }

            //character goes through the plugboard for the second time
            output = _plugboard.Replace(output);

            return output;
        }

        public void BindPlugBoardCharacters(char character1, char character2)
        {
            _plugboard.BindCharacters(character1, character2);
        }

        private void RotateRotor(int index = 0)
        { 
            if (index > _rotors.Count)
            {
                throw new Exception("Rotor index cannot be greater than the number of rotors");
            }

            if (_rotors[index].Rotate())
            {
                int nextIndex = index + 1;

                if (nextIndex < _rotors.Count)
                {
                    RotateRotor(nextIndex);
                }
            }
        }
    }
}
