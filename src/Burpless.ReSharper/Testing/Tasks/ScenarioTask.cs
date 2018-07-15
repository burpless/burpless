using System;
using System.Xml;
using JetBrains.ReSharper.TaskRunnerFramework;

namespace Burpless.ReSharper.Testing.Tasks
{
    public class ScenarioTask : RemoteTask, IEquatable<ScenarioTask>
    {
        public ScenarioTask(XmlElement element)
            : base(element)
        {
        }

        public ScenarioTask()
            : base(BurplessTestProvider.RunnerId)
        {
        }

        public override bool IsMeaningfulTask => true;

        public override bool Equals(RemoteTask other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(ScenarioTask other)
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
