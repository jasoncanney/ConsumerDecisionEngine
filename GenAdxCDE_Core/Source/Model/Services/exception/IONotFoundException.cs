using System;
using System.Runtime.Serialization;

/// 
namespace GenAdxCDE.Source.Model.Services
{

    [Serializable]
    public class IONotFoundException : Exception
    {
        public IONotFoundException()
        {
        }

        public IONotFoundException(string message) : base(message)
        {
        }

        public IONotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IONotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}