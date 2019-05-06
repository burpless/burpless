using System.Collections.Generic;
using JetBrains.Application.Processes;
using JetBrains.Lifetimes;
using JetBrains.ProjectModel;
using JetBrains.ProjectModel.NuGet.Packaging;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Channel.Json;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.Common;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.DotNetVsTest;
using JetBrains.Util;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class TestArtifactExplorer : DotNetVsTestArtifactExplorer<BurplessTestProvider>
    {
        public TestArtifactExplorer(
            Lifetime lifetime,
            BurplessTestProvider provider,
            IDotNetCoreSdkResolver sdkResolver,
            IJsonBasedUnitTestServerFactory serverFactory,
            ISolutionProcessStartInfoPatcher processStartInfoPatcher,
            IDotNetVsTestRunSettingsProvider runSettingsProvider,
            IDotNetCoreTestCaseMap testCaseMap,
            ITestElementMapperFactory mapperFactory,
            NuGetInstalledPackageChecker installedPackageChecker,
            IUnitTestingSettings unitTestingSettings,
            ILogger logger)
            : base(lifetime, provider, sdkResolver, serverFactory, processStartInfoPatcher, runSettingsProvider, testCaseMap, mapperFactory, installedPackageChecker, unitTestingSettings, logger)
        {
        }

        protected override IEnumerable<string> RequiredNuGetDependencies()
        {
            throw new System.NotImplementedException();
        }
    }
}
