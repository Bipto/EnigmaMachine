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

        public void Reset()
        {
            _plugboard.Reset();
        }

        public char Process(char character)
        {
            char output = char.ToUpper(character);

            //character goes through the plugboard for the first time
            output = _plugboard.Replace(output);

            //character goes through each rotor forward
            for (int i = 0; i < _rotors.Count; i++)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Process(output);
            }

            //character goes through each rotor backwards
            for (int i = _rotors.Count - 1; i >= 0; i--)
            {
                Rotor rotor = _rotors[i];
                output = rotor.Process(output);
            }

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
