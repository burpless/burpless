using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class FeatureSyntaxNode : SyntaxNode
    {
        public DescriptionSyntaxNode Description { get; }

        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitFeature(this);
        }

        internal override IEnumerable<SyntaxNode> GetNodes()
        {
            yield break;
        }
    }
}
