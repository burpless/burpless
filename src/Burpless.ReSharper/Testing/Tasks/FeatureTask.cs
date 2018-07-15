using System;
using System.Xml;
using JetBrains.ReSharper.TaskRunnerFramework;

namespace Burpless.ReSharper.Testing.Tasks
{
    public class FeatureTask : RemoteTask, IEquatable<FeatureTask>
    {
        public FeatureTask(XmlElement element)
            : base(element)
        {
        }

        public FeatureTask()
            : base(BurplessTestProvider.RunnerId)
        {
        }

        public override bool IsMeaningfulTask => true;

        public override bool Equals(RemoteTask other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(FeatureTask other)
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
