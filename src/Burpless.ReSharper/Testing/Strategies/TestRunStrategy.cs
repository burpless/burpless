using JetBrains.Application.Processes;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Channel.Json;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.DotNetTest;
using JetBrains.Util;

namespace Burpless.ReSharper.Testing.Strategies
{
    [SolutionComponent]
    public class TestRunStrategy : DotNetTestRunStrategy
    {
        public TestRunStrategy(
            IJsonBasedUnitTestServerFactory serverFactory,
            UnitTestElementMapperFactory mapperFactory,
            IDotNetTestCaseMap testCaseMap,
            IUnitTestResultManager resultManager,
            ISolutionProcessStartInfoPatcher processStartInfoPatcher,
            ILogger logger)
            : base(serverFactory, mapperFactory, testCaseMap, resultManager, processStartInfoPatcher, logger)
        {
        }
    }
}
