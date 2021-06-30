using System.Collections.Generic;

namespace Burpless.Syntax
{
    public abstract class SyntaxNode
    {
        public SyntaxNode Parent { get; }

        public abstract void Accept(SyntaxVisitor visitor);

        internal abstract IEnumerable<SyntaxNode> GetNodes();

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
