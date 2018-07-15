using JetBrains.ReSharper.TaskRunnerFramework;

namespace Burpless.ReSharper.Testing.Execution
{
    public class TestRunner
    {
        private readonly IRemoteTaskServer _server;

        public TestRunner(IRemoteTaskServer server)
        {
            _server = server;
        }

        public void Run(TestContext context)
        {

        }
    }
}
