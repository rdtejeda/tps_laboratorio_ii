using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class AccesoNoAutorizadoException : Exception
    {
        public AccesoNoAutorizadoException()
        {
        }
        public AccesoNoAutorizadoException(string message) : base(message)
        {
        }
        public AccesoNoAutorizadoException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected AccesoNoAutorizadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
