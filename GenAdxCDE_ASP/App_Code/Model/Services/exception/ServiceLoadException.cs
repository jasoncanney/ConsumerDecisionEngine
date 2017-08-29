using System;
using System.Runtime.Serialization;

namespace GenAdxCDE.Source.Model.Services
{
    [Serializable]
    public class ServiceLoadException : Exception
    {
        public ServiceLoadException()
        {
        }

        public ServiceLoadException(string message) : base(message)
        {
            Console.WriteLine("ServiceLoadException");

        }

        public ServiceLoadException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("ServiceLoadException - innerException");

        }

        protected ServiceLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}