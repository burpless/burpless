namespace Burpless.Syntax
{
    public class ScenarioSyntaxNode : SyntaxNode
    {
        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.VisitScenario(this);
        }
    }
}
