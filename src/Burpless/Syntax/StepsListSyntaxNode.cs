namespace Burpless.Syntax
{
    public class StepsListSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitStepsList(this);
        }
    }
}
