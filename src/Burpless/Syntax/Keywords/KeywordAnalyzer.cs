namespace Burpless.Syntax.Keywords
{
    public class KeywordAnalyzer
    {
        private const int InitialState = 1;

        private readonly KeywordGrammar _grammar;

        private int _state;

        public KeywordAnalyzer(KeywordGrammar grammar)
        {
            _grammar = grammar;
        }

        public void Reset()
        {
            _state = InitialState;
        }

        public KeywordResult Advance(char key)
        {
            _state = _grammar.NextState(key, _state);

            if (_state == 0)
                return KeywordResult.Rejected;

            if (_grammar.IsAccepting(_state))
                return KeywordResult.Accepted;

            return KeywordResult.Advanced;
        }
    }
}
