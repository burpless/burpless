namespace Burpless.Syntax
{
    public class FeatureSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitFeature(this);
        }
    }
}
