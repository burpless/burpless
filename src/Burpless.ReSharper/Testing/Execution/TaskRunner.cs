using Burpless.ReSharper.Testing.Tasks;
using JetBrains.ReSharper.TaskRunnerFramework;

namespace Burpless.ReSharper.Testing.Execution
{
    public class TaskRunner : RecursiveRemoteTaskRunner
    {
        private readonly TestRunner _runner;

        public TaskRunner(IRemoteTaskServer server)
            : base(server)
        {
            _runner = new TestRunner(server);
        }

        public override void ExecuteRecursive(TaskExecutionNode node)
        {
            var assemblyTask = node.RemoteTask as AssemblyTask;

            if (assemblyTask == null)
                return;

            var context = new TestContext(assemblyTask);

            PopulateContext(context, node);

            _runner.Run(context);
        }

        private void PopulateContext(TestContext context, TaskExecutionNode node)
        {
            var childNodes = node.Children.Flatten(x => x.Children);

            foreach (var childNode in childNodes)
            {
                switch (childNode.RemoteTask)
                {
                    case ScenarioTask task:
                        break;

                    case FeatureTask task:
                        break;
                }
            }
        }
    }
}
