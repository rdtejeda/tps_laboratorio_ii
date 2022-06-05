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
