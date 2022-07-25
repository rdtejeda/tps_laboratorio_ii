using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class ClienteNoDisponibleException : Exception
    {
        public ClienteNoDisponibleException()
        {
        }
        public ClienteNoDisponibleException(string message) : base(message)
        {
        }
        public ClienteNoDisponibleException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected ClienteNoDisponibleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
