using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistirDatos;
using Excepciones;

namespace Entidades
{
    public class ClienteDTV : Persona
    {
        private string direccion;
        private Servicio servicio;
        public ClienteDTV()
        {
        }
        public ClienteDTV(string dni, string nombre, string apellido, string direccion) : base(dni, nombre, apellido)
        {
           this.direccion = direccion;
        }
        public ClienteDTV(string dni, string nombre, string apellido, string direccion, Servicio servicio) : this(dni, nombre, apellido, direccion)
        {
            this.servicio = servicio;
        }
        public string Direccion { get => direccion; set => direccion = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Direccion} - {Dni}";
        }
        public static ClienteDTV IdentificarCliente(string dni)
        {
            ClienteDTV retorno = new ClienteDTV();
            string path = null;
            if ((path = AppDomain.CurrentDomain.BaseDirectory) is not null)
            {
                try
                {
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();
                    List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");
                    foreach (ClienteDTV item in listaClientesosDTV)
                    {
                        if (item.Dni == dni)
                        {
                            retorno = item;
                            return retorno;
                        }
                    }
                    throw new ClienteNoDisponibleException("El Dni actual no es cliente");
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

            //List<ClienteDTV> lista = new List<ClienteDTV>();
            //List<Servicio.ESenialesPremiun> listasnial = new List<Servicio.ESenialesPremiun>();
            //listasnial.Add(Servicio.ESenialesPremiun.HBO);
            //listasnial.Add(Servicio.ESenialesPremiun.Paramount);
            //listasnial.Add(Servicio.ESenialesPremiun.FutbolArgentino);
            //listasnial.Add(Servicio.ESenialesPremiun.NBA);
            //listasnial.Add(Servicio.ESenialesPremiun.Star);

            //lista.Add(new ClienteDTV("18223125", "Roberto", "Tejeda", "Amoedo 234",
            //    new Servicio(Servicio.EServicios.DTVGo, Servicio.EFormaPago.TarjetaCredito, Servicio.ECantidadDecos.Dos, listasnial)));
            //lista.Add(new ClienteDTV("12345678", "Jose", "Peruez", "Urquiza 234",
            //    new Servicio(Servicio.EServicios.DTVGo, Servicio.EFormaPago.TarjetaDebito, Servicio.ECantidadDecos.Cuatro, listasnial)));
            //lista.Add(new ClienteDTV("12345678", "Luis", "ASDasd", "Mitre 234",
            //    new Servicio(Servicio.EServicios.DTVGo, Servicio.EFormaPago.TarjetaCredito, Servicio.ECantidadDecos.Dos, listasnial)));

            //string path = AppDomain.CurrentDomain.BaseDirectory;

            //Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();

            //listaSerializadaC.Guardar(path, "clientesDTV.xml", lista);
            
            //List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Lista de Usuarios");
            //foreach (UsuarioDTV item in listaUsuariosDTV)
            //{

            //    sb.AppendLine(item.ToString());
            //}
            //MessageBox.Show(sb.ToString());

            //StringBuilder sb1 = new StringBuilder();
            //sb1.AppendLine("Lista de Clientes");
            //foreach (ClienteDTV item in listaClientesosDTV)
            //{

            //    sb1.AppendLine(item.ToString());
            //}
            return retorno;
        }   
    }
}
