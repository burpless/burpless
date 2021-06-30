using System.Collections.Generic;
using System.Linq;
using Burpless.Configuration;

namespace Burpless.Syntax.Keywords
{
    public class KeywordGrammarBuilder
    {
        private readonly List<string> _phrases = new List<string>();

        public KeywordGrammarBuilder(Dialect dialect)
        {
            var colonSeparated = dialect.GetKeywords(KeywordType.Feature)
                .Concat(dialect.GetKeywords(KeywordType.Background))
                .Concat(dialect.GetKeywords(KeywordType.Scenario))
                .Concat(dialect.GetKeywords(KeywordType.ScenarioOutline))
                .Concat(dialect.GetKeywords(KeywordType.Examples))
                .Select(x => x + ":");

            var spaceSeparated = dialect.GetKeywords(KeywordType.Given)
                .Concat(dialect.GetKeywords(KeywordType.When))
                .Concat(dialect.GetKeywords(KeywordType.Then))
                .Concat(dialect.GetKeywords(KeywordType.And))
                .Concat(dialect.GetKeywords(KeywordType.But))
                .Select(x => x + " ");

            _phrases.AddRange(colonSeparated);
            _phrases.AddRange(spaceSeparated);
        }

        public KeywordGrammar Build()
        {
            var stateTree = BuildStateTree();

            var states = GetAllStates(stateTree)
                .OrderBy(x => x.Id)
                .ToArray();

            var alphabet = BuildAlphabet();
            var characterMap = BuildCharacterMap(alphabet);
            var acceptingStates = BuildAcceptingStates(states);
            var transitions = BuildTransitions(states, alphabet, characterMap);

            return new KeywordGrammar(characterMap, transitions, acceptingStates);
        }

        private char[] BuildAlphabet()
        {
            return _phrases
                .SelectMany(x => x)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
        }

        private int[] BuildCharacterMap(char[] alphabet)
        {
            var characterMap = new int[char.MaxValue];

            for (var i = 0; i < alphabet.Length; i++)
                characterMap[alphabet[i]] = i + 1;

            return characterMap;
        }

        private KeywordState BuildStateTree()
        {
            var id = 1;

            var initialState = new KeywordState(id++, !_phrases.Any(), true);

            foreach (var phrase in _phrases)
            {
                var state = initialState;

                for (var i = 0; i < phrase.Length; i++)
                    state = state.GetOrCreateState(phrase[i], i == phrase.Length - 1, () => id++);
            }

            return initialState;
        }

        private bool[] BuildAcceptingStates(KeywordState[] states)
        {
            var acceptingStates = new bool[states.Length + 1];

            foreach (var state in states.Where(x => x.IsAccepting))
                acceptingStates[state.Id] = true;

            return acceptingStates;
        }

        private int[,] BuildTransitions(KeywordState[] states, char[] alphabet, int[] characterMap)
        {
            var transitions = new int[states.Length + 1, alphabet.Length + 1];

            foreach (var state in states)
            {
                foreach (var nextState in state.NextStates)
                {
                    var row = state.Id;
                    var column = characterMap[nextState.Key];

                    transitions[row, column] = nextState.Value.Id;
                }
            }

            return transitions;
        }

        private IEnumerable<KeywordState> GetAllStates(KeywordState initialState)
        {
            yield return initialState;

            foreach (var nextState in initialState.NextStates.Values)
            {
                foreach (var state in GetAllStates(nextState))
                    yield return state;
            }
        }
    }
}
