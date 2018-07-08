using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace Burpless.ReSharper.Tree
{
    public static class GherkinNodeType
    {
        public static readonly CompositeNodeType GherkinFile = new GherkinCompositeNodeType<GherkinFile>("File", 2000);
    }
}
