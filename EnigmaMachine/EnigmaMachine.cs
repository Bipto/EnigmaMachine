namespace EnigmaMachine
{
    internal class EnigmaMachine
    {
        internal PlugBoard _plugboard = new PlugBoard();

        List<Rotor> _rotors = new List<Rotor>();

        public EnigmaMachine()
        {
            _rotors.Add(new Rotor("DMTWSILRUYQNKFEJCAZBPGXOHV"));
        }

        public void RemovePlugs()
        {
            _plugboard.Reset();
        }

        public void Reset()
        {
            foreach (Rotor rotor in _rotors)
            {
                rotor.Reset();
            }
        }

        public char Encrypt(char character)
        {
            char output = char.ToUpper(character);

            //character goes through the plugboard for the first time
            output = _plugboard.Replace(output);

            //character goes through each rotor forward
            for (int i = 0; i < _rotors.Count; i++)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Encrypt(output);
            }

            //character goes through each rotor backwards
            //for (int i = _rotors.Count - 1; i >= 0; i--)
            //{
            //    Rotor rotor = _rotors[i];
            //    output = rotor.Encrypt(output);
            //}

            //character goes through the plugboard for the second time
            output = _plugboard.Replace(output);

            return output;
        }

        public char Decrypt(char character)
        {
            char output = char.ToUpper(character);

            //character goes through the plugboard for the first time
            output = _plugboard.Replace(output);

            //character goes through each rotor forward
            for (int i = 0; i < _rotors.Count; i++)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Decrypt(output);
            }

            //character goes through each rotor backwards
            //for (int i = _rotors.Count - 1; i >= 0; i--)
            //{
            //    Rotor rotor = _rotors[i];
            //    output = rotor.Decrypt(output);
            //}

            //character goes through the plugboard for the second time
            output = _plugboard.Replace(output);

            return output;
        }

        public void BindPlugBoardCharacters(char character1, char character2)
        {
            _plugboard.BindCharacters(character1, character2);
        }
    }
}
