using JetBrains.ProjectModel;
using JetBrains.ReSharper.TaskRunnerFramework;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Strategy;

namespace Burpless.ReSharper.Testing.Strategies
{
    [SolutionComponent]
    public class OutOfProcessTestRunStrategy : TaskRunnerOutOfProcessUnitTestRunStrategy
    {
        public OutOfProcessTestRunStrategy(IUnitTestAgentManager agentManager, IUnitTestResultManager resultManager)
            : base(agentManager, resultManager, new RemoteTaskRunnerInfo(BurplessTestProvider.RunnerId, typeof(TaskRunner)))
        {
        }
    }
}
