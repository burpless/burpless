using System;

namespace Burpless.Console
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class TestClass : Attribute
    {
        public TestClass()
        {
            System.Console.WriteLine("this is a long string" + 12 + " with extra     spaces \t");
        }
    }
}
