using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace Burpless.ReSharper.Tree
{
    public class GherkinCompositeNodeType<T> : CompositeNodeType
        where T : CompositeElement, new()
    {
        public GherkinCompositeNodeType(string name, int index)
            : base(name, index)
        {
        }

        public override CompositeElement Create()
        {
            return new T();
        }
    }
}
