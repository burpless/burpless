using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace Burpless.ReSharper.Parsing
{
    public class GherkinLexer : ILexer
    {
        public GherkinLexer(IBuffer buffer)
        {
            Buffer = buffer;
        }

        public object CurrentPosition { get; set; }

        public TokenNodeType TokenType { get; private set; }

        public int TokenStart { get; private set; }

        public int TokenEnd { get; private set; }

        public IBuffer Buffer { get; }

        public void Start()
        {
            Advance();
        }

        public void Advance()
        {
        }
    }
}
