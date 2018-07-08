using Burpless.ReSharper.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;

namespace Burpless.ReSharper.Parsing
{
    public class GherkinParser : IParser
    {
        public IFile ParseFile()
        {
            return new GherkinFile();
        }
    }
}
