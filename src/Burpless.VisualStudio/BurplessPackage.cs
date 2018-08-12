using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace Burpless.VisualStudio
{
    [Guid("2bbd68d8-1a5f-4671-b70f-bd507dc95e91")]
    [PackageRegistration(AllowsBackgroundLoading = true, UseManagedResourcesOnly = true)]
    public class BurplessPackage : AsyncPackage
    {
        protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            return Task.CompletedTask;
        }
    }
}
