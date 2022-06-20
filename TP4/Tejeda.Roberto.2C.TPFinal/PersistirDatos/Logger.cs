using Excepciones;
using System;
using System.IO;
using System.Text;


namespace PersistirDatos
{
    public static class Logger
    {
        /// <summary>
        /// Crear archivo de texto
        /// </summary>
        /// <param name="mensaje">Mensaje</param>
        /// <param name="nombreArchivo">Nombre del archivo</param>
        /// <exception cref="DatosException"></exception>
        public static void Log(string mensaje, string nombreArchivo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/TP4/" + nombreArchivo, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{DateTime.Now} {mensaje}");
                }
            }
            catch (Exception ex)
            {
                throw new DatosException("Error en txt");
            }
        }
    }
}
