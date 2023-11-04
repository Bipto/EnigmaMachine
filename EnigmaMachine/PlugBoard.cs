namespace EnigmaMachine
{
    internal class PlugBoard
    {
        private struct CharacterSet
        {
            internal char Character1;
            internal char Character2;

            internal bool Contains(char character)
            {
                if (Character1 == character || Character2 == character)
                {
                    return true;
                }

                return false;
            }

            internal char SwapCharacter(char character)
            {
                if (Character1 == character)
                {
                    character = Character2;
                }
                else if (Character2 == character)
                {
                    character = Character1;
                }
                return character;
            }
        }

        private List<CharacterSet> _characterSets = new List<CharacterSet>();

        public void BindCharacters(char a, char b)
        {
            foreach (var characterSet in _characterSets)
            {
                if (characterSet.Contains(a))
                {
                    throw new Exception($"Character [{a}] is already mapped within this set");
                }
                else if (characterSet.Contains(b))
                {
                    throw new Exception($"Character [{b}] is already mapped within this set");
                }
            }

            CharacterSet set = new CharacterSet();
            set.Character1 = a;
            set.Character2 = b;
            _characterSets.Add(set);
        }

        public void Reset()
        {
            _characterSets.Clear();
        }

        public char Replace(char character)
        {
            char c = character;

            foreach (var characterSet in _characterSets)
            {
                c = characterSet.SwapCharacter(c);
            }

            return c;
        }
    }
}
