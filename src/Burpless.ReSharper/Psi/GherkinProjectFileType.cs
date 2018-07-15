using JetBrains.Annotations;
using JetBrains.ProjectModel;

namespace Burpless.ReSharper.Psi
{
    [ProjectFileTypeDefinition(Name)]
    public class GherkinProjectFileType : KnownProjectFileType
    {
        public new const string Name = GherkinLanguage.Name;

        public new const string PresentableName = GherkinLanguage.PresentableName;

        [UsedImplicitly(ImplicitUseKindFlags.Assign)]
        public new static readonly GherkinProjectFileType Instance;

        public GherkinProjectFileType()
            : base(Name, PresentableName, new[] { ".feature" })
        {
        }
    }
}
