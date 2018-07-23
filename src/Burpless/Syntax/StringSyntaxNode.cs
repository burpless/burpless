namespace Burpless.Syntax
{
    public class StringSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitString(this);
        }
    }
}
