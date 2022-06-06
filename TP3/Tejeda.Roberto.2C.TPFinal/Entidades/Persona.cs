using System;

namespace Entidades
{
    public class Persona
    {
        private string dni;
        private string nombre;
        private string apellido;
        public Persona()
        {
        }
        public Persona(string dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;          
        }
        public string Dni  { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
