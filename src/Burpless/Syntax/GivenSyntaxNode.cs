namespace Burpless.Syntax
{
    public class GivenSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitGiven(this);
        }
    }
}
