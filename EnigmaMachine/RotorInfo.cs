namespace EnigmaMachine
{
    public struct RotorInfo
    {
        string _wiring = string.Empty;
        int _initialOffset = 0;
        int _notchPosition = 0;

        public string Wiring => _wiring;
        public int InitialOffset => _initialOffset;
        public int NotchPosition => _notchPosition;

        public RotorInfo()
        {
        }

        public RotorInfo(string wiring)
        {
            _wiring = wiring;
        }

        public RotorInfo(string wiring, int initialOffset)
        {
            _wiring = wiring;
            _initialOffset = initialOffset;
        }

        public RotorInfo(string wiring, int initialOffset, int notchPosition)
        {
            _wiring = wiring;
            _initialOffset = initialOffset;
            _notchPosition = notchPosition;
        }
    }
}
