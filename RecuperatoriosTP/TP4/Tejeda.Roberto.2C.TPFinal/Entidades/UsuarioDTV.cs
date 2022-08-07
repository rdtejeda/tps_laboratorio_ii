using Excepciones;
using PersistirDatos;
using System;
using System.Collections.Generic;


namespace Entidades
{
    public class UsuarioDTV : Persona
    {
        private string nombreUsuario;
        private string password;

        public UsuarioDTV()
        {
        }
        public UsuarioDTV(string dni, string nombre, string apellido) : base(dni, nombre, apellido)
        {
        }
        public UsuarioDTV(string dni, string nombre, string apellido, string nombreUsuario, string password)
            : base(dni, nombre, apellido)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Passwword { get => password; set => password = value; }
        /// <summary>
        /// Sobrecrga ToString devuleve datos de Usuario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Nombre} - {Apellido} - {NombreUsuario}";
        }
        /// <summary>
        /// Corrobora la pertenencia de un nombre de usuario y password en la base de datos SQL
        /// </summary>
        /// <param name="nombreUsuario">Usuario</param>
        /// <param name="password">Password</param>
        /// <returns>Retorno true si hay coinsidencia</returns>
        public static bool IdentificarUsuarioSQL(string nombreUsuario, string password)
        {
            bool retorno = false;
            string path = null;
            try
            {
                List<UsuarioDTV> listaUsuariosDTV = UsuariosDTVDAO.Leer();
                foreach (UsuarioDTV item in listaUsuariosDTV)
                {
                    if (item.NombreUsuario == nombreUsuario && item.Passwword == password)
                    {
                        retorno = true;
                        return retorno;
                    }
                }
                throw new AccesoNoAutorizadoException("Combinacio Usuario / Password incorreta");
            }
            catch (ArchivoException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        /// <summary>
        /// Corrobora la pertenencia de un nombre de usuario y password en archivo XML
        /// </summary>
        /// <param name="nombreUsuario">Usuario</param>
        /// <param name="password">Passwword</param>
        /// <returns></returns>
        public static bool IdentificarUsuarioXML(string nombreUsuario, string password)
        {
            bool retorno = false;
            string path = null;
            if (((path = Environment.CurrentDirectory + @"\Archivos\") is not null))
            {
                try
                {
                    Serializar<List<UsuarioDTV>> listaSerializada = new Serializar<List<UsuarioDTV>>();
                    List<UsuarioDTV> listaUsuariosDTV = listaSerializada.Leer(path, "usuarioDTV.xml");
                    foreach (UsuarioDTV item in listaUsuariosDTV)
                    {
                        if (item.NombreUsuario == nombreUsuario && item.Passwword == password)
                        {
                            retorno = true;
                            return retorno;
                        }
                    }
                    throw new AccesoNoAutorizadoException("Combinacio Usuario / Password incorreta");
                }
                catch (ArchivoException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return retorno;
        }
    }
}
