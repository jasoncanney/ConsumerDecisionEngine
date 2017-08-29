using System;
using System.Runtime.Serialization;

/// 
namespace GenAdxCDE.Source.Model.Services
{

    [Serializable]
    public class ClassNotFoundException : Exception
    {
        public ClassNotFoundException()
        {
        }

        public ClassNotFoundException(string message) : base(message)
        {
        }

        public ClassNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClassNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}