using System;

namespace Burpless.Configuration
{
    public class DialectNotFoundException : ArgumentException
    {
        public DialectNotFoundException(string message, string paramName, string code)
            : base(message, paramName)
        {
            Code = code;
        }

        public string Code { get; }
    }
}
