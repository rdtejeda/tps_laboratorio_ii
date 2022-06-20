using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class ClienteSinServiciosException : Exception
    {
        public ClienteSinServiciosException()
        {
        }

        public ClienteSinServiciosException(string message) : base(message)
        {
        }

        public ClienteSinServiciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClienteSinServiciosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
