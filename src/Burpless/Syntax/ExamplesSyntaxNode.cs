namespace Burpless.Syntax
{
    public class ExamplesSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitExamples(this);
        }
    }
}
