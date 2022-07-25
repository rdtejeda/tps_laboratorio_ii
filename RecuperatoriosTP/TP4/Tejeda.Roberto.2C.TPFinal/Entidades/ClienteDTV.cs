using Excepciones;
using PersistirDatos;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Environment;

namespace Entidades
{
    public class ClienteDTV : Persona
    {
        private string direccion;
        private Servicio servicio;
        public ClienteDTV()
        {
            this.servicio = new Servicio();
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
        /// <summary>
        /// Sobrecarga ToString para mostrar datos de Cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLIENTE N° {Dni}");
            sb.AppendLine($"{Apellido}, {Nombre}");
            sb.AppendLine("DIRECCION");
            sb.AppendLine($"{Direccion}");
            if (this.Servicio is not null)
            {
                sb.AppendLine($"SERVICIO {this.Servicio.Servivio}");
                sb.AppendLine($"FORMA DE PAGO {this.Servicio.FormaPago}");
                sb.AppendLine($"CANTIDAD DE DECODIFICADORES {this.Servicio.CantidadDecos}");
                sb.AppendLine("LISTA DE SEÑALES PREMIUN");
                foreach (Servicio.ESenialesPremiun item in this.Servicio.SenialPremium)
                {
                    sb.AppendLine($"{item}");
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Identifica si un Cliente (DNI) esta en la base de datos 
        /// </summary>
        /// <param name="dni">DNI/Numero de cliente</param>
        /// <returns>Retorna el cliente</returns>
        public static ClienteDTV IdentificarCliente(string dni)
        {
            ClienteDTV retorno = null;
            string path = null;
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP4\") is not null))
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
        /// <summary>
        /// Busca un Cliente por su DNI/Numero de cliente en la base de datos
        /// </summary>
        /// <param name="dni">DNI/Numero de cliente</param>
        /// <returns>Tru si es cliente y False si no lo es</returns>
        public static bool BuscarEnListaClientes(string dni)
        {
            bool retorno = false;
            string path = null;
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP4\") is not null))
                {
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();
                    List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");
                    foreach (ClienteDTV item in listaClientesosDTV)
                    {
                        if (item.Dni == dni)
                        {
                            retorno = true;
                            return retorno;
                        }
                    }
                }
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
        /// Agrega un nuevo cliente a la base de datos
        /// </summary>
        /// <param name="cliente">Cliente para agregar</param>
        public static void AgregarNuevoCliente(ClienteDTV cliente)
        {
            string path = null;
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP4\") is not null))
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
        /// <summary>
        /// Modifica los servicios de un cliente
        /// </summary>
        /// <param name="cliente">Clieneta a modificar</param>
        public static void ModificarServiviosCliente(ClienteDTV cliente)
        {
            string path = null;
            try
            {
                if (((path = GetFolderPath(SpecialFolder.Desktop) + @"\TP4\") is not null))
                {
                    Serializar<List<ClienteDTV>> listaSerializadaC = new Serializar<List<ClienteDTV>>();
                    List<ClienteDTV> listaClientesosDTV = listaSerializadaC.Leer(path, "clientesDTV.xml");
                    foreach (ClienteDTV item in listaClientesosDTV)
                    {
                        if (item.Dni == cliente.Dni)
                        {
                            listaClientesosDTV.Remove(item);
                            listaClientesosDTV.Add(cliente);
                            break;
                        }
                    }
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
