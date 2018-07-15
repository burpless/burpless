using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.UnitTestFramework;

namespace Burpless.ReSharper.Testing
{
    public class FileExplorer : IRecursiveElementProcessor
    {
        private readonly UnitTestElementFactory _factory;
        private readonly IUnitTestElementsObserver _observer;
        private readonly Func<bool> _interrupted;

        public FileExplorer(UnitTestElementFactory factory, IUnitTestElementsObserver observer, Func<bool> interrupted)
        {
            _factory = factory;
            _observer = observer;
            _factory = factory;
            _observer = observer;
            _interrupted = interrupted;
        }

        public bool ProcessingIsFinished
        {
            get
            {
                if (_interrupted())
                    throw new OperationCanceledException();

                return false;
            }
        }

        public bool InteriorShouldBeProcessed(ITreeNode element)
        {
            if (element is ITypeMemberDeclaration)
                return element is ITypeDeclaration;

            return true;
        }

        public void ProcessBeforeInterior(ITreeNode element)
        {
            if (!(element is IDeclaration declaration))
                return;

            var declaredElement = declaration.DeclaredElement;
        }

        public void ProcessAfterInterior(ITreeNode element)
        {
        }
    }
}
