using JetBrains.ProjectModel;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.Common;
using JetBrains.Util.Dotnet.TargetFrameworkIds;

namespace Burpless.ReSharper.Testing
{
    public class UnitTestElementMapper : TestElementMapper
    {
        private readonly UnitTestElementFactory _elementFactory;

        public UnitTestElementMapper(IProject project, TargetFrameworkId targetFrameworkId, UnitTestElementFactory elementFactory)
            : base(project, targetFrameworkId)
        {
            _elementFactory = elementFactory;
        }

        public override IUnitTestElement Map(Test test, bool isDiscovery, out bool wasChanged)
        {
            wasChanged = false;

            using (ReadLockCookie.Create())
            {
                return _elementFactory.GetOrCreateScenario();
            }
        }
    }
}
