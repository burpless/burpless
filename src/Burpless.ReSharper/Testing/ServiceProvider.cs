using Burpless.ReSharper.Testing.Strategies;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore;
using JetBrains.ReSharper.UnitTestFramework.Strategy;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class ServiceProvider
    {
        private readonly BurplessTestProvider _provider;
        private readonly ISolution _solution;
        private readonly IUnitTestElementIdFactory _elementIdFactory;
        private readonly IDotNetCoreSdkResolver _dotNetCoreSdkResolver;

        public ServiceProvider(
            BurplessTestProvider provider,
            ISolution solution,
            IUnitTestElementIdFactory elementIdFactory,
            IDotNetCoreSdkResolver dotNetCoreSdkResolver)
        {
            _provider = provider;
            _solution = solution;
            _elementIdFactory = elementIdFactory;
            _dotNetCoreSdkResolver = dotNetCoreSdkResolver;
        }

        public IUnitTestRunStrategy GetRunStrategy(IUnitTestElement element)
        {
            var project = element.Id.Project;

            if (!project.IsDotNetCoreProject() || element.Id.TargetFrameworkId.IsNetFramework)
                return _solution.GetComponent<OutOfProcessTestRunStrategy>();

            if (_dotNetCoreSdkResolver.GetVersion(project) < ImportantSdkVersions.VsTestVersion)
                return _solution.GetComponent<TestRunStrategy>();

            return _solution.GetComponent<VsTestRunStrategy>();
        }

        public UnitTestElementId CreateId(IProject project, TargetFrameworkId targetFrameworkId, string id)
        {
            return _elementIdFactory.Create(_provider, project, targetFrameworkId, id);
        }
    }
}
