namespace Burpless.Syntax
{
    public class SyntaxVisitor
    {
        public virtual void Visit(SyntaxNode node)
        {
        }

        public virtual void VisitFeature(FeatureSyntaxNode node)
        {
        }
    }
}
