using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace PersistirDatos
{
    public class Serializar<T> : IResguardarDatos<T> where T : class, new()
    {
        static ManejarArchivos manejarArchivos;

        static Serializar()
        {
            manejarArchivos = new ManejarArchivos();
        }
        public void Guardar(string path, string nombreArchivo, T contenido)
        {
            try
            {
                //verifica si la extension es json y serializa en json sino xml
                if (Path.GetExtension(nombreArchivo) == ".json")
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string json = JsonSerializer.Serialize(contenido, options);

                    //Guardo el objeto en formato JSON en un archivo de texto
                    manejarArchivos.Guardar(path, nombreArchivo, json);

                }
                else if (Path.GetExtension(nombreArchivo) == ".xml")
                {
                    //Pat.Combine combina dos string en una ruta
                    string rutaCompleta = Path.Combine(path, nombreArchivo);

                    using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));

                        //serializa el objeto y lo guarda en el archivo que recibe en el stream
                        serializer.Serialize(streamWriter, contenido);
                    }
                }
                else
                {
                    throw new ArchivoException("La extension es invalida");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public T Leer(string path, string nombreArchivo)
        {
            try
            {
                if (Path.GetExtension(nombreArchivo) == ".json")
                {
                    //leo el archivo de texto con el objeto serializado en json
                    string json = manejarArchivos.Leer(path, nombreArchivo);

                    //recibe el string y lo convierte en objeto
                    return JsonSerializer.Deserialize<T>(json);
                }
                if (Path.GetExtension(nombreArchivo) == ".xml")
                {
                    string rutaCompleta = Path.Combine(path, nombreArchivo);
                    using (XmlTextReader xmlTextReader = new XmlTextReader(rutaCompleta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        return serializer.Deserialize(xmlTextReader) as T;
                    }
                }
                else
                {
                    throw new ArchivoException("Extension invalida");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
