using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading;
using Burpless.VisualStudio.Language;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace Burpless.VisualStudio
{
    [Guid("2bbd68d8-1a5f-4671-b70f-bd507dc95e91")]
    [PackageRegistration(AllowsBackgroundLoading = true, UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("Burpless Language Service", "Visual Studio support for the Gherkin language.", "1.0", IconResourceID = 400)]
    [ProvideEditorExtension(typeof(EditorFactory), ".feature", 1000)]
    [ProvideEditorLogicalView(typeof(EditorFactory), VSConstants.LOGVIEWID.TextView_string, IsTrusted = true)]
    [ProvideEditorFactory(typeof(EditorFactory), 110, CommonPhysicalViewAttributes = (int)__VSPHYSICALVIEWATTRIBUTES.PVA_SupportsPreview, TrustLevel = __VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
    [ProvideLanguageExtension(typeof(GherkinLanguageService), ".feature")]
    [ProvideLanguageCodeExpansion(typeof(GherkinLanguageService), "Gherkin", 0, "Gherkin", null)]
    [ProvideLanguageService(typeof(GherkinLanguageService), "Gherkin", 101, ShowCompletion = true, EnableAsyncCompletion = true, EnableAdvancedMembersOption = true, HideAdvancedMembersByDefault = false, QuickInfo = true, ShowDropDownOptions = true, DefaultToInsertSpaces = true, EnableCommenting = true)]
    public class BurplessPackage : AsyncPackage
    {
        protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            var editorFactory = new EditorFactory(this, typeof(GherkinLanguageService).GUID);

            RegisterEditorFactory(editorFactory);

            AddService<GherkinServiceProvider>((container, type) => new GherkinServiceProvider(container), true);

            return Task.CompletedTask;
        }

        private void AddService<T>(ServiceCreatorCallback callback, bool promote)
        {
            ((IServiceContainer)this).AddService(typeof(T), callback, promote);
        }

        private void AddService<T>(T instance, bool promote)
        {
            ((IServiceContainer) this).AddService(typeof(T), instance, promote);
        }
    }
}
