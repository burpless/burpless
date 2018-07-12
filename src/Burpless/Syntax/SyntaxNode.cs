using System.Collections.Generic;

namespace Burpless.Syntax
{
    public abstract class SyntaxNode
    {
        public abstract void Accept(SyntaxVisitor visitor);

        public IEnumerable<SyntaxNode> Descendants()
        {
            return null;
        }

        public IEnumerable<SyntaxNode> Children()
        {
            return null;
        }

        public IEnumerable<SyntaxError> GetErrors()
        {
            return null;
        }
    }
}
