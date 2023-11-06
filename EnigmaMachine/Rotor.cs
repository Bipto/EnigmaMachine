using System.Text.Json.Serialization;

namespace EnigmaMachine
{
    public class Rotor
    {
        private const string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private KeyValuePair<char, char>[] _chars = new KeyValuePair<char, char>[26];

        private int _offset = 0;
        private int _initialOffset = 0;
        private int _notchPosition = 0;
        private string _wiring = string.Empty;

        public string Wiring
        {
            get { return _wiring; }
            set 
            { 
                _wiring = value;
                SetupWiring();
            }
        }

        public int InitialOffset
        {
            get { return _initialOffset; }
            set { _initialOffset = value; }
        }

        public int NotchPosition
        {
            get { return _notchPosition; }
            set { _notchPosition= value; }
        }

        public Rotor() { }

        public Rotor(RotorInfo info)
        {
            _wiring = info.Wiring;
            _offset = info.InitialOffset;
            _initialOffset = info.InitialOffset;
            _notchPosition = info.NotchPosition;
            SetupWiring();            
        }

        private void SetupWiring()
        {
            //an invalid number of wires were entered
            if (Wiring.Length != _alphabet.Length)
            {
                throw new Exception("An invalid number of wires were entered");
            }

            //check that we only have one of each character
            List<char> foundCharacters = new List<char>();
            int index = 0;
            foreach (char c in Wiring)
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
                    KeyValuePair<char, char> mapping = new KeyValuePair<char, char>(_alphabet[index], Wiring[index]);
                    _chars[index] = mapping;
                }

                index++;
            }
        }

        public char Encrypt(char character)
        {
            int? index = FindKey(character);

            if (index is null)
            {
                return character;
            }

            index += _offset;
            index %= _chars.Length;

            char output = _chars[index.Value].Value;
            return output;
        }

        public char Decrypt(char character)
        {
            int? index = FindValue(character);
            index -= _offset;

            if (index is null)
            {
                return character;
            }

            if (index.Value < 0)
            {
                // subtract the negative index from the length of the string
                index = _chars.Length + index;
            }

            char output = _chars[index.Value].Key;
            return output;
        }

        private int? FindKey(char character)
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

            return null;
        }

        private int? FindValue(char character)
        {
            int index = 0;
            foreach (var pair in _chars)
            {
                if (pair.Value == character)
                {
                    return index;
                }

                index++;
            }
            return null;
        }


        public bool Rotate()
        {
            _offset++;
            _offset %= _chars.Length;

            if (_offset == _notchPosition)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _offset = _initialOffset;
        }

        public RotorInfo GetRotorInfo()
        {
            RotorInfo info = new RotorInfo(_wiring, _initialOffset, _notchPosition);
            return info;
        }
    }
}
