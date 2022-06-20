using Excepciones;
using System;
using System.IO;

namespace PersistirDatos
{
    internal class ManejarArchivos : IResguardarDatos<string>
    {
        /// <summary>
        /// Genera el Path y Guarda el archivo
        /// </summary>
        /// <param name="path">Para construir Ruta absoluta</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <param name="contenido">Contenido</param>
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
        /// <param name="path">Para construir Ruta absoluta</param>
        /// <param name="nombreArchivo">Nombre de archivo</param>
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
