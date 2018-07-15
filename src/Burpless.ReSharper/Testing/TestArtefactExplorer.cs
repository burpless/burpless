using JetBrains.Application.Processes;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework.Channel.Json;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.DotNetTest;
using JetBrains.Util;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class TestArtefactExplorer : DotNetTestArtefactExplorer<BurplessTestProvider>
    {
        public TestArtefactExplorer(
            BurplessTestProvider provider,
            IDotNetCoreSdkResolver sdkResolver,
            IJsonBasedUnitTestServerFactory serverFactory,
            UnitTestElementMapperFactory mapperFactory,
            ISolutionProcessStartInfoPatcher processStartInfoPatcher,
            IDotNetTestCaseMap testCaseMap,
            ILogger logger)
            : base(provider, sdkResolver, serverFactory, mapperFactory, processStartInfoPatcher, testCaseMap, logger)
        {
        }
    }
}
