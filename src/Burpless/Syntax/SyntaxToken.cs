namespace Burpless.Syntax
{
    public struct SyntaxToken
    {
        public SyntaxToken(string text, SyntaxTokenType type, TextSpan span)
        {
            Text = text;
            Type = type;
            Span = span;
        }

        public string Text { get; }

        public SyntaxTokenType Type { get; }

        public TextSpan Span { get; }
    }
}
