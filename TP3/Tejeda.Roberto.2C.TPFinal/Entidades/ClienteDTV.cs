using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteDTV : Persona
    {
        private int id;
        private string direccion;
        private Servicio servicio;
       
        public ClienteDTV()
        {
        }
        public ClienteDTV(string dni, string nombre, string apellido, int id, string direccion) : base(dni, nombre, apellido)
        {
            this.id = id;
            this.direccion = direccion;
        }
        public ClienteDTV(string dni, string nombre, string apellido, int id, string direccion, Servicio servicio) : this(dni, nombre, apellido, id, direccion)
        {
            this.servicio = servicio;
        }
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public override string ToString()
        {
            
            return $"{Nombre} - {Direccion} - {Dni}";
        }
    }
}
