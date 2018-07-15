using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace Burpless.ReSharper.Parsing
{
    public class GherkinLexerFactory : ILexerFactory
    {
        public ILexer CreateLexer(IBuffer buffer)
        {
            return new GherkinLexer(buffer);
        }
    }
}
