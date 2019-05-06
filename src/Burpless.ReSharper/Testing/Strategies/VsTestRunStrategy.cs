using System.Collections.Generic;
using JetBrains.Application.Processes;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Channel.Json;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.Common;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.DotNetVsTest;
using JetBrains.Util;

namespace Burpless.ReSharper.Testing.Strategies
{
    [SolutionComponent]
    public class VsTestRunStrategy : DotNetVsTestRunStrategy
    {
        public VsTestRunStrategy(
            IJsonBasedUnitTestServerFactory serverFactory,
            ITestElementMapperFactory mapperFactory,
            IDotNetVsTestRunSettingsProvider runSettingsProvider,
            IDotNetVsTestCaseMapProvider testCaseMapProvider,
            IUnitTestElementRepository elementRepository,
            IUnitTestResultManager resultManager,
            ISolutionProcessStartInfoPatcher processStartInfoPatcher,
            ILogger logger,
            IUnitTestingSettings unitTestingSettings,
            IEnumerable<IRunSettingsPostProcessor> runSettingsPostProcessors)
            : base(serverFactory, mapperFactory, runSettingsProvider, testCaseMapProvider, elementRepository, resultManager, processStartInfoPatcher, logger, unitTestingSettings, runSettingsPostProcessors)
        {
        }
    }
}
