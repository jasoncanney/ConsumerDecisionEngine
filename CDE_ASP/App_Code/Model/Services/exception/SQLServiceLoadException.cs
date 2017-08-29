using System;
using System.Runtime.Serialization;

namespace GenAdxCDE.Source.Model.Services
{
    [Serializable]
    public class SQLServiceLoadException : Exception
    {
        public SQLServiceLoadException()
        {
        }

        public SQLServiceLoadException(string message) : base(message)
        {
            Console.WriteLine("SQLServiceLoadException" + message);

        }

        public SQLServiceLoadException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("SQLServiceLoadException - innerException" + message);

        }

        protected SQLServiceLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}