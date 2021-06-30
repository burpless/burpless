using System;
using System.Collections.Generic;

namespace Burpless.Syntax.Keywords
{
    internal class KeywordState
    {
        public KeywordState(int id, bool isAccepting, bool isInitial)
        {
            Id = id;
            IsAccepting = isAccepting;
            IsInitial = isInitial;
        }

        public int Id { get; }

        public bool IsAccepting { get; }

        public bool IsInitial { get; }

        public Dictionary<char, KeywordState> NextStates { get; } = new Dictionary<char, KeywordState>();

        public KeywordState GetOrCreateState(char key, bool isAccepting, Func<int> idGenerator)
        {
            if (NextStates.TryGetValue(key, out var state))
                return state;

            var newState = new KeywordState(idGenerator(), isAccepting, false);

            NextStates[key] = newState;

            return newState;
        }
    }
}
