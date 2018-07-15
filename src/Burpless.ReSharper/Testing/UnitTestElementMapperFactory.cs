using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.Common;

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

        public ITestElementMapper Create(IProject project, TargetFrameworkId targetFrameworkId)
        {
            return new UnitTestElementMapper(project, targetFrameworkId, _elementFactory);
        }
    }
}
