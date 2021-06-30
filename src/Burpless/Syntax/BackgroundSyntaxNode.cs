using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class BackgroundSyntaxNode : SyntaxNode
    {
        public DescriptionSyntaxNode Description { get; }

        public StepsListSyntaxNode Steps { get; }

        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitBackground(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield return Description;
            yield return Steps;
        }
    }
}
