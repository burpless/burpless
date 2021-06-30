using System.ComponentModel.Design;

namespace Burpless.VisualStudio
{
    public class GherkinServiceProvider
    {
        private readonly IServiceContainer _container;

        public GherkinServiceProvider(IServiceContainer container)
        {
            _container = container;
        }
    }
}
