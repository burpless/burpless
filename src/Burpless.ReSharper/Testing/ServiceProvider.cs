using Burpless.ReSharper.Testing.Strategies;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Strategy;
using JetBrains.Util.Dotnet.TargetFrameworkIds;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class ServiceProvider
    {
        private readonly BurplessTestProvider _provider;
        private readonly ISolution _solution;
        private readonly IUnitTestElementIdFactory _elementIdFactory;
        private readonly OutOfProcessTestRunStrategy _defaultRunStrategy;

        public ServiceProvider(
            BurplessTestProvider provider,
            ISolution solution,
            IUnitTestElementIdFactory elementIdFactory,
            OutOfProcessTestRunStrategy defaultRunStrategy)
        {
            _provider = provider;
            _solution = solution;
            _elementIdFactory = elementIdFactory;
            _defaultRunStrategy = defaultRunStrategy;
        }

        public IUnitTestRunStrategy GetRunStrategy(IUnitTestElement element)
        {
            var targetFrameworkId = element.Id.TargetFrameworkId;

            if (targetFrameworkId.IsNetFramework || !element.Id.Project.IsDotNetCoreProject() || !targetFrameworkId.IsNetCoreApp)
                return _defaultRunStrategy;

            return  _solution.GetComponent<VsTestRunStrategy>();
        }

        public UnitTestElementId CreateId(IProject project, TargetFrameworkId targetFrameworkId, string id)
        {
            return _elementIdFactory.Create(_provider, project, targetFrameworkId, id);
        }
    }
}
