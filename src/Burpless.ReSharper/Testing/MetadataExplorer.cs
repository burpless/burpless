using System.Threading;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.ReSharper.UnitTestFramework;

namespace Burpless.ReSharper.Testing
{
    public class MetadataExplorer
    {
        private readonly UnitTestElementFactory _factory;
        private readonly IUnitTestElementsObserver _observer;

        public MetadataExplorer(UnitTestElementFactory factory, IUnitTestElementsObserver observer)
        {
            _factory = factory;
            _observer = observer;
        }

        public void ExploreAssembly(IProject project, IMetadataAssembly assembly, CancellationToken token)
        {
            using (ReadLockCookie.Create())
            {
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    if (token.IsCancellationRequested)
                        break;
                }
            }
        }
    }
}
