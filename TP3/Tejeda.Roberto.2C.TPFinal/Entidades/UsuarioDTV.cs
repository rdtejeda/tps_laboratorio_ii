using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public UsuarioDTV(string dni, string nombre, string apellido, string nombreUsuario, string passwword)
            : base(dni, nombre, apellido)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = passwword;
        }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Passwword { get => password; set => password = value; }
        public override string ToString()
        {
            return $"{Nombre} - {Apellido} - {NombreUsuario}";
        }
    }
}
