using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.Common;
using JetBrains.Util.Dotnet.TargetFrameworkIds;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class UnitTestElementMapperFactory : ITestElementMapperFactory
    {
        private readonly UnitTestElementFactory _elementFactory;

        public UnitTestElementMapperFactory(UnitTestElementFactory elementFactory)
        {
            _elementFactory = elementFactory;
        }

        public ITestElementMapper Create(UnitTestElementOrigin origin, IProject project, TargetFrameworkId targetFrameworkId)
        {
            return new UnitTestElementMapper(project, targetFrameworkId, _elementFactory);
        }
    }
}
