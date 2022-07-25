using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    public class DatosException : Exception
    {
        public DatosException()
        {
        }

        public DatosException(string message) : base(message)
        {
        }

        public DatosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
