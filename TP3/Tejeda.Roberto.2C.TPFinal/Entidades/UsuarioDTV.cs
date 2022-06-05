﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using PersistirDatos;


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
        public override string ToString()
        {
            return $"{Nombre} - {Apellido} - {NombreUsuario}";
        }

        public static bool IdentificarUsuario(string nombreUsuario, string password)
        {
            bool retorno = false;
            string path = null;
            if ((path = AppDomain.CurrentDomain.BaseDirectory) is not null)
            {
                try
                {
                    Serializar<List<UsuarioDTV>> listaSerializada = new Serializar<List<UsuarioDTV>>();
                    List<UsuarioDTV> listaUsuariosDTV = listaSerializada.Leer(path, "usuariosDTV.xml");
                    foreach (UsuarioDTV item in listaUsuariosDTV)
                    {
                        if(item.NombreUsuario==nombreUsuario && item.Passwword==password)
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
