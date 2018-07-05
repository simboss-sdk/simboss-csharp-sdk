using System;
namespace Simboss.Csharp.Sdk.Exception
{
    public class SimbossException : System.Exception
    {
        public SimbossException() : this(string.Empty) { }

        public SimbossException(string message) : this(message, null) { }

        public SimbossException(string message, System.Exception cause) : base(message, cause) { }
    }
}
