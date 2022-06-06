using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistirDatos;
using Excepciones;
using static System.Environment;

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
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP3\") is not null)) // ((path = AppDomain.CurrentDomain.BaseDirectory) is not null)
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
                    throw new ClienteNoDisponibleException($"el Dni {dni}.");
                }
            }
            catch (ClienteNoDisponibleException)
            {
                throw;
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
        public static void AgregarNuevoCliente(ClienteDTV cliente)
        {
            string path = null;
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP3\") is not null)) //((path = AppDomain.CurrentDomain.BaseDirectory) is not null)
                {
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();                   
                    List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");
                    listaClientesosDTV.Add(cliente);
                    listaSerializadaC.Guardar(path, "clientesDTV.xml", listaClientesosDTV); 
                }
            }
            catch (ClienteNoDisponibleException)
            {
                throw;
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
    }
}
