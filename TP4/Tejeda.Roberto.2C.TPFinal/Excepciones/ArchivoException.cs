using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        public ArchivoException()
        {
        }
        public ArchivoException(string message) : base(message)
        {
        }
        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected ArchivoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
