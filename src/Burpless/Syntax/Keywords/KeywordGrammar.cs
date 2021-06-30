namespace Burpless.Syntax.Keywords
{
    public class KeywordGrammar
    {
        private readonly int[] _characterMap;
        private readonly int[,] _transitions;
        private readonly bool[] _acceptingStates;

        public KeywordGrammar(int[] characterMap, int[,] transitions, bool[] acceptingStates)
        {
            _characterMap = characterMap;
            _transitions = transitions;
            _acceptingStates = acceptingStates;
        }

        public bool IsAccepting(int state)
        {
            if (state <= 0 || state >= _acceptingStates.Length)
                return false;

            return _acceptingStates[state];
        }

        public int NextState(char key, int state)
        {
            var row = state;
            var column = _characterMap[key];

            if (row == 0 || column == 0)
                return 0;

            return _transitions[row, column];
        }
    }
}
