using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
