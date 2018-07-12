using System.Collections.Generic;
using Burpless.Configuration;

namespace Burpless.Syntax
{
    public class SyntaxTree
    {
        public string FileName { get; }

        public ParserOptions Options { get; }

        public int Length { get; }

        public Dialect Dialect { get; }

        public SyntaxNode GetRoot()
        {
            return null;
        }

        public IEnumerable<SyntaxError> GetErrors()
        {
            return null;
        }
    }
}
