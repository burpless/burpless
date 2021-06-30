using System.Collections.Generic;

namespace Burpless.Syntax
{
    public class TokenLexer
    {
        private readonly string _text;

        private List<SyntaxToken> _leadingTokens = new List<SyntaxToken>();
        private List<SyntaxToken> _trailingTokens = new List<SyntaxToken>();

        private TokenLexerMode _mode = TokenLexerMode.StartOfLine;
        private int _position;

        public TokenLexer(string text, ParserOptions options = null)
        {
            _text = text;

            Options = options ?? ParserOptions.Default;
        }

        public ParserOptions Options { get; }

        private bool EndOfFile => _position >= _text.Length;

        public SyntaxToken Next()
        {
            if (EndOfFile)
                return Create(SyntaxTokenType.EndOfFile);

            if (_mode == TokenLexerMode.StartOfLine)
                return ParseToken();

            return default(SyntaxToken);
        }

        private SyntaxToken Create(SyntaxTokenType type)
        {
            return new SyntaxToken("", type, new TextSpan());
        }

        private SyntaxToken ParseToken()
        {
            return default(SyntaxToken);
        }

        private void ParseWhitespace(List<SyntaxToken> tokens)
        {
            var c = Peek();

            while (IsWhitespace(c) || IsNewLine(c))
            {
                if (IsNewLine(c))
                {

                }
            }
        }

        private SyntaxToken ParseNewLine(char c)
        {
            var start = _position;

            if (c == '\r' && !EndOfFile && Peek() == '\n')
                Advance();

            var spen = new TextSpan(start, _position - start);

            return new SyntaxToken("", SyntaxTokenType.NewLine, spen);
        }

        private void Advance()
        {
            _position++;
        }

        private bool IsWhitespace(char c)
        {
            return char.IsWhiteSpace(c) && !IsNewLine(c);
        }

        private bool IsNewLine(char c)
        {
            return c == '\r' || c == '\n';
        }

        private char Peek()
        {
            return _text[_position];
        }

        private char Peek(int offset)
        {
            var index = _position + offset;

            if (index >= _text.Length)
                return char.MinValue;

            return _text[index];
        }
    }
}
