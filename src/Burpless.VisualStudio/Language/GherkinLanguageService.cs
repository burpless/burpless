using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Burpless.VisualStudio.Language
{
    [Guid("c756b8da-25ed-4104-ac77-85e6189924e8")]
    public class GherkinLanguageService : LanguageService
    {
        public override string Name { get; } = "Gherkin";

        public GherkinLanguageService(object site)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            SetSite(site);
        }

        public override LanguagePreferences GetLanguagePreferences()
        {
            throw new System.NotImplementedException();
        }

        public override IScanner GetScanner(IVsTextLines buffer)
        {
            throw new System.NotImplementedException();
        }

        public override AuthoringScope ParseSource(ParseRequest req)
        {
            throw new System.NotImplementedException();
        }

        public override string GetFormatFilterList()
        {
            throw new System.NotImplementedException();
        }
    }
}
