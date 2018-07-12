namespace Burpless.Syntax
{
    public class SyntaxError
    {
        public TextSpan Location { get; }

        public string Message { get; }

        public SyntaxErrorSeverity Severity { get; }
    }
}
