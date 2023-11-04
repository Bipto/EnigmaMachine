namespace EnigmaMachine
{
    internal class Rotor
    {
        private string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private KeyValuePair<char, char>[] _chars = new KeyValuePair<char, char>[26];

        public Rotor(string wiring)
        {
            //an invalid number of wires were entered
            if (wiring.Length != _alphabet.Length)
            {
                throw new Exception("An invalid number of wires were entered");
            }

            //check that we only have one of each character
            List<char> foundCharacters = new List<char>();
            int index = 0;
            foreach (char c in wiring)
            {
                if (foundCharacters.Contains(c))
                {
                    throw new Exception("Wire cannot connect to the same character more than once!");
                }
                else if (!char.IsLetter(c))
                {
                    throw new Exception("Wiring contains an invalid character (not a letter)");
                }
                else
                {
                    foundCharacters.Add(char.ToUpper(c));

                    //map the characters to each other
                    KeyValuePair<char, char> mapping = new KeyValuePair<char, char>(_alphabet[index], wiring[index]);
                    _chars[index] = mapping;
                }

                index++;
            }
        }

        public char Process(char character)
        {
            int index = Find(character);
            return _chars[index].Value;
        }

        private int Find(char character)
        {
            int index = 0;
            foreach (var pair in _chars)
            {
                if (pair.Key == character)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }
    }
}
