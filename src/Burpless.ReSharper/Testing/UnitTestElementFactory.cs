using Burpless.ReSharper.Testing.Elements;
using JetBrains.ReSharper.UnitTestFramework;

namespace Burpless.ReSharper.Testing
{
    public class UnitTestElementFactory
    {
        public IUnitTestElement GetOrCreateScenario()
        {
            return new ScenarioElement();
        }
    }
}
