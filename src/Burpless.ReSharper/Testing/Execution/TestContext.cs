using Burpless.ReSharper.Testing.Tasks;

namespace Burpless.ReSharper.Testing.Execution
{
    public class TestContext
    {
        private AssemblyTask _assemblyTask;

        public TestContext(AssemblyTask assemblyTask)
        {
            _assemblyTask = assemblyTask;
        }
    }
}
