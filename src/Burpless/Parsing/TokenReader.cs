using System;
using System.IO;

namespace Burpless.Parsing
{
    public class TokenReader : IDisposable
    {
        private readonly string _value;

        public TokenReader(TextReader reader)
            : this(reader.ReadToEnd())
        {
        }

        public TokenReader(string value)
        {
            _value = value;
        }

        public int Position { get; private set; }

        private bool EndOfFile => Position >= _value.Length;

        public TokenType Read()
        {
            if (EndOfFile)
                return TokenType.EndOfFile;

            var c = Peek();

            if (IsNewLine(c))
                return ReadNewLine();

            if (IsWhitespace(c))
                return ReadWhitespace();

            if (IsSecondaryKeyword(c))
                return ReadSecondaryKeyword();

            if (IsDocString(c))
                ReadDocString();

            return ReadText();
        }

        private TokenType ReadNewLine()
        {
            var c = Advance();

            if (c == '\r' && !EndOfFile && Peek() == '\n')
                Advance();

            return TokenType.NewLine;
        }

        private TokenType ReadWhitespace()
        {
            while (!EndOfFile)
            {
                var c = Peek();

                if (!IsWhitespace(c))
                    break;

                Advance();
            }

            return TokenType.Whitespace;
        }

        private TokenType ReadSecondaryKeyword()
        {
            var c = Advance();

            if (c == '#')
                return TokenType.Comment;

            if (c == ':')
                return TokenType.Colon;

            if (c == '|')
                return TokenType.Table;

            if (c == '@')
                return TokenType.Tag;

            if (c == '<')
                return TokenType.OpenParameter;

            if (c == '>')
                return TokenType.CloseParameter;

            throw new InvalidOperationException();
        }

        private TokenType ReadDocString()
        {
            Position += 3;

            return TokenType.DocString;
        }

        private TokenType ReadText()
        {
            while (!EndOfFile)
            {
                var c = Peek();

                if (IsSecondaryKeyword(c) || IsWhitespace(c) || IsNewLine(c))
                    break;

                Advance();
            }

            return TokenType.Text;
        }

        private bool IsSecondaryKeyword(char c)
        {
            return c == '#' || c == ':' || c == '|' || c == '@' || c == '<' || c == '>';
        }

        private bool IsNewLine(char c)
        {
            return c == '\r' || c == '\n';
        }

        private bool IsDocString(char c)
        {
            if (c != '"')
                return false;

            if (Position + 3 >= _value.Length)
                return false;

            return _value[Position + 1] == '"' && _value[Position + 2] == '"';
        }

        private bool IsWhitespace(char c)
        {
            return char.IsWhiteSpace(c) && !IsNewLine(c);
        }

        private char Peek()
        {
            return _value[Position];
        }

        private char Advance()
        {
            return _value[Position++];
        }

        public void Dispose()
        {
        }
    }
}
