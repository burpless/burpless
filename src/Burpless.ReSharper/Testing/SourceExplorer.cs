using System;
using System.Threading;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ProjectModel.Assemblies.AssemblyToAssemblyResolvers;
using JetBrains.ProjectModel.Assemblies.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Exploration;
using JetBrains.Util;

namespace Burpless.ReSharper.Testing
{
    [SolutionComponent]
    public class SourceExplorer : UnitTestExplorerFrom.DotNetArtefacts, IUnitTestExplorerFromFile
    {
        private readonly ILogger _logger;

        public SourceExplorer(
            ISolution solution,
            BurplessTestProvider provider,
            AssemblyToAssemblyReferencesResolveManager resolveManager,
            ResolveContextManager resolveContextManager,
            ILogger logger)
            : base(solution, provider, resolveManager, resolveContextManager, logger)
        {
            _logger = logger;
        }

        public override void ProcessProject(IProject project, FileSystemPath assemblyPath, MetadataLoader loader, IUnitTestElementsObserver observer, CancellationToken token)
        {
            var factory = new UnitTestElementFactory();
            var explorer = new MetadataExplorer(factory, observer);

            void ExploreAction(IMetadataAssembly assembly) => explorer.ExploreAssembly(project, assembly, token);

            MetadataElementsSource.ExploreProject(project, assemblyPath, loader, observer, _logger, token, ExploreAction);

            observer.OnCompleted();
        }

        public void ProcessFile(IFile psiFile, IUnitTestElementsObserver observer, Func<bool> interrupted)
        {
            var factory = new UnitTestElementFactory();
            var explorer = new FileExplorer(factory, observer, interrupted);

            psiFile.ProcessDescendants(explorer);

            observer.OnCompleted();
        }
    }
}
