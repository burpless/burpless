using System;
using System.Xml;
using JetBrains.ReSharper.TaskRunnerFramework;

namespace Burpless.ReSharper.Testing.Tasks
{
    public class AssemblyTask : RemoteTask, IEquatable<AssemblyTask>
    {
        public AssemblyTask(XmlElement element)
            : base(element)
        {
        }

        public AssemblyTask(string projectId, string assemblyLocation)
            : base(BurplessTestProvider.RunnerId)
        {
            ProjectId = projectId;
            AssemblyLocation = assemblyLocation;
        }

        public string ProjectId { get; }

        public string AssemblyLocation { get; }

        public override bool IsMeaningfulTask => false;

        public override bool Equals(RemoteTask other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(AssemblyTask other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
