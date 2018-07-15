using System;
using System.Collections.Generic;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.ReSharper.UnitTestFramework.Launch;
using JetBrains.ReSharper.UnitTestFramework.Strategy;

namespace Burpless.ReSharper.Testing.Elements
{
    public abstract class Element : IUnitTestElement
    {
        public UnitTestElementId Id { get; }

        public string Kind { get; }

        public ISet<UnitTestElementCategory> OwnCategories { get; }

        public string ExplicitReason { get; }

        public IUnitTestElement Parent { get; set; }

        public ICollection<IUnitTestElement> Children { get; }

        public string ShortName { get; }

        public bool Explicit { get; }

        public UnitTestElementState State { get; set; }

        public string GetPresentation(IUnitTestElement parent = null, bool full = false)
        {
            throw new NotImplementedException();
        }

        public UnitTestElementNamespace GetNamespace()
        {
            throw new NotImplementedException();
        }

        public UnitTestElementDisposition GetDisposition()
        {
            throw new NotImplementedException();
        }

        public IDeclaredElement GetDeclaredElement()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProjectFile> GetProjectFiles()
        {
            throw new NotImplementedException();
        }

        public IUnitTestRunStrategy GetRunStrategy(IHostProvider hostProvider)
        {
            throw new NotImplementedException();
        }

        public IList<UnitTestTask> GetTaskSequence(ICollection<IUnitTestElement> explicitElements, IUnitTestRun run)
        {
            throw new NotImplementedException();
        }
    }
}
