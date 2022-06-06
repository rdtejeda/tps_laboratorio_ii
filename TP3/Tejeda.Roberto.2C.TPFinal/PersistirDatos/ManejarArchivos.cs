using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace PersistirDatos
{
    internal class ManejarArchivos : IResguardarDatos<string>
    {
        /// <summary>
        /// Genera el Path y Guarda el archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nombreArchivo"></param>
        /// <param name="contenido"></param>
        /// <exception cref="ArchivoException"></exception>
        public void Guardar(string path, string nombreArchivo, string contenido)
        {
            try
            {
               string rutaCompleta = Path.Combine(path, nombreArchivo);

                using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new ArchivoException("El directorio no existe", ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Abre el archivo y Lee
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nombreArchivo"></param>
        /// <returns>Devuelve el contenido del archivo</returns>
        /// <exception cref="ArchivoException"></exception>
        public string Leer(string path, string nombreArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(path, nombreArchivo);
                using (StreamReader streamReader = new StreamReader(rutaCompleta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new ArchivoException("El directorio no existe", ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoException("El archivo no existe", ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
