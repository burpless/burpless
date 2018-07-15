using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Impl;

namespace Burpless.ReSharper.Psi
{
    public class GherkinPsiProjectFileProperties : DefaultPsiProjectFileProperties
    {
        public GherkinPsiProjectFileProperties(IProjectFile projectFile, IPsiSourceFile sourceFile, bool shouldBuildPsi)
            : base(projectFile, sourceFile)
        {
            ShouldBuildPsi = shouldBuildPsi;
        }

        public override bool ShouldBuildPsi { get; }
    }
}
