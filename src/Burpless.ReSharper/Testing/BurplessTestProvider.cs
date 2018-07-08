using System;
using JetBrains.Metadata.Reader.API;
using JetBrains.Metadata.Utils;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.DotNetCore.DotNetVsTest;
using JetBrains.Util.Reflection;

namespace Burpless.ReSharper.Testing
{
    [UnitTestProvider]
    public class BurplessTestProvider : IDotNetVsTestBasedUnitTestProvider
    {
        public const string RunnerId = "Burpless";

        private static readonly AssemblyNameInfo AssemblyReferenceName = AssemblyNameInfoFactory.Create2(RunnerId, null);

        public string ID => RunnerId;

        public string Name => RunnerId;

        public bool IsElementOfKind(IDeclaredElement declaredElement, UnitTestElementKind elementKind)
        {
            throw new NotImplementedException();
        }

        public bool IsElementOfKind(IUnitTestElement element, UnitTestElementKind elementKind)
        {
            throw new NotImplementedException();
        }

        public bool IsSupported(IHostProvider hostProvider, IProject project, TargetFrameworkId targetFrameworkId)
        {
            return IsSupported(project, targetFrameworkId);
        }

        public bool IsSupported(IProject project, TargetFrameworkId targetFrameworkId)
        {
            using (ReadLockCookie.Create())
            {
                return ReferencedAssembliesService.IsProjectReferencingAssemblyByName(project, targetFrameworkId, AssemblyReferenceName, out AssemblyNameInfo _);
            }
        }

        public int CompareUnitTestElements(IUnitTestElement x, IUnitTestElement y)
        {
            throw new NotImplementedException();
        }

        public string GetExtensionName(IProject project, TargetFrameworkId targetFrameworkId)
        {
            return "Burpless.TestAdapter.dll";
        }
    }
}
