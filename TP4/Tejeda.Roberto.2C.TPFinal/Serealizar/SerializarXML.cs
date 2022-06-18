using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializar
{
    public class SerializarXML<T> : IPersintirDatos<T> where T : class, new()
    {
        public void Guardar(string path, string nombreArchivo, T contenido)
        {
            throw new NotImplementedException();
        }

        public T Leer(string path, string nombreArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
