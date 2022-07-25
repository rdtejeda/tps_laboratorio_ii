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
        /// <summary>
        /// Serializa y Guarda archivos tipo Jayso y XML
        /// </summary>
        /// <param name="path">Ruta absoluta</param>
        /// <param name="nombreArchivo">NOMBRE ARCHIVO</param>
        /// <param name="contenido">cONTENIDO</param>
        public void Guardar(string path, string nombreArchivo, T contenido)
        {
            try
            {
                if (Path.GetExtension(nombreArchivo) == ".json")
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string json = JsonSerializer.Serialize(contenido, options);
                    manejarArchivos.Guardar(path, nombreArchivo, json);

                }
                else if (Path.GetExtension(nombreArchivo) == ".xml")
                {
                    string rutaCompleta = Path.Combine(path, nombreArchivo);
                    using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(streamWriter, contenido);
                    }
                }
                else
                {
                    throw new ArchivoException("La extension del archivo es invalida");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deserializa y lee el archivo tipo Jayson y xml
        /// </summary>
        /// <param name="path">Ruta absoluta</param>
        /// <param name="nombreArchivo">Nombre archivo</param>
        /// <returns>Objeto leido</returns>
        public T Leer(string path, string nombreArchivo)
        {
            T retorno=null;
            try
            {
                if (Path.GetExtension(nombreArchivo) == ".json")
                {
                    string json = manejarArchivos.Leer(path, nombreArchivo);
                    retorno= JsonSerializer.Deserialize<T>(json);
                }
                if (Path.GetExtension(nombreArchivo) == ".xml")
                {
                    string rutaCompleta = Path.Combine(path, nombreArchivo);
                    using (XmlTextReader xmlTextReader = new XmlTextReader(rutaCompleta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        retorno = serializer.Deserialize(xmlTextReader) as T;
                    }
                }
                else
                {
                    throw new ArchivoException("La extension del archivo es invalida");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
    }
}
