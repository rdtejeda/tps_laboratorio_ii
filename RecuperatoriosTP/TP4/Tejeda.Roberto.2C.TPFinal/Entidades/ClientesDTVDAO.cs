using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Entidades.Servicio;

namespace Entidades
{
    public static class ClientesDTVDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static ClientesDTVDAO()
        {
            connectionString = @"Server=.;Database=TEJEDA2C-TPF; Trusted_Connection=True;";
            connection = new SqlConnection(ClientesDTVDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        /// <summary>
        /// Elimina un Usuario
        /// </summary>
        /// <param name="dni">Dni a eliminar</param>
        public static void Eliminar(string dni)
        {
            try
            {
                string query = "DELETE FROM Clientes WHERE Dni = @Dni";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Dni", int.Parse(dni));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Modifica datos de un cliente
        /// </summary>
        /// <param name="cliente">Cliente a modoificra</param>
        public static void Modificar(ClienteDTV cliente)
        {
            try
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, EServicio = @EServicio," +
                " EFormaPago = @EFormaPago, ECantidadDecos = @ECantidadDecos, HBO = @HBO, NBA = @NBA, Star = @Star, Paramount = @Paramount, FutbolArgentino = @FutbolArgentino WHERE Dni = @Dni";                   
                
                connection.Open();                
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Dni", int.Parse(cliente.Dni));
                command.Parameters.AddWithValue("Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("Direccion", cliente.Direccion);
                if (cliente.Servicio is not null)
                {
                    command.Parameters.AddWithValue("EServicio", cliente.Servicio.Servivio.ToString());
                    command.Parameters.AddWithValue("EFormaPago", cliente.Servicio.FormaPago.ToString());
                    command.Parameters.AddWithValue("ECantidadDecos", cliente.Servicio.CantidadDecos);
                    if (cliente.Servicio.SenialPremium.Contains(ESenialesPremiun.HBO))
                    {
                        command.Parameters.AddWithValue("HBO", true);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("HBO", false);
                    }
                    if (cliente.Servicio.SenialPremium.Contains(ESenialesPremiun.NBA))
                    {
                        command.Parameters.AddWithValue("NBA", true);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("NBA", false);
                    }
                    if (cliente.Servicio.SenialPremium.Contains(ESenialesPremiun.Star))
                    {
                        command.Parameters.AddWithValue("Star", true);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Star", false);
                    }
                    if (cliente.Servicio.SenialPremium.Contains(ESenialesPremiun.Paramount))
                    {
                        command.Parameters.AddWithValue("Paramount", true);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("Paramount", false);
                    }
                    if (cliente.Servicio.SenialPremium.Contains(ESenialesPremiun.FutbolArgentino))
                    {
                        command.Parameters.AddWithValue("FutbolArgentino", true);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("FutbolArgentino", false);
                    }
                }

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Inserta nuevo usuario dado de alt
        /// </summary>
        /// <param name="cliente">Usuario sib servicioa asociados</param>
        public static void Guardar(ClienteDTV cliente)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Clientes (Dni, Nombre, Apellido, Direccion, EServicio, EFormaPago, ECantidadDecos, HBO, NBA, Star, Paramount, FutbolArgentino)" +
                    " VALUES (@Dni, @Nombre, @Apellido, @Direccion, @Eservicio, @EFormaPago, @ECantidadDecos, @HBO, @NBA, @Star, @Paramount, @FutbolArgentino)";
                
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Dni", int.Parse(cliente.Dni));
                command.Parameters.AddWithValue("Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("EServicio", "NoActivo");
                command.Parameters.AddWithValue("EFormaPago", "TarjetaCredito");
                command.Parameters.AddWithValue("ECantidadDecos", 0);
                command.Parameters.AddWithValue("HBO", false);
                command.Parameters.AddWithValue("NBA", false); 
                command.Parameters.AddWithValue("Star", false); 
                command.Parameters.AddWithValue("Paramount", false); 
                command.Parameters.AddWithValue("FutbolArgentino", false);                 
               
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Lee y devuelve lista de usuarios
        /// </summary>
        /// <returns></returns>
        public static List<ClienteDTV> Leer()
        {
            List<ClienteDTV> lista = new List<ClienteDTV>();
            try
            {
                string query = "SELECT * FROM Clientes";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string dni = dataReader.GetInt32(0).ToString();
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string direccion = dataReader.GetString(3);
                    string servicio = dataReader.GetString(4);
                    EServicios eServicio = new EServicios();
                    switch (servicio)
                    {
                        case "NoActivo":
                            eServicio = EServicios.NoActivo;
                            break;
                        case "Oro":
                            eServicio = EServicios.Oro;
                            break;
                        case "Plata":
                            eServicio = EServicios.Plata;
                            break;
                        case "DTVGo":
                            eServicio = EServicios.DTVGo;
                            break;
                        default:
                            eServicio = EServicios.NoActivo;
                            break;
                    }
                    string formaPago = dataReader.GetString(5);
                    if (formaPago is null)
                        formaPago = "?";
                    EFormaPago eFormaPago = new EFormaPago();
                    switch (formaPago)
                    {
                        case "TarjetaCredito":
                            eFormaPago = EFormaPago.TarjetaCredito;
                            break;
                        case "TarjetaDebito":
                            eFormaPago = EFormaPago.TarjetaDebito;
                            break;
                        default:
                            eFormaPago = EFormaPago.TarjetaCredito;
                            break;
                    }
                    int cantidadDecos = dataReader.GetInt32(6);
                    
                    ECantidadDecos eCantidadDecos = new ECantidadDecos();
                    switch (cantidadDecos)
                    {
                        case 0:
                            eCantidadDecos = ECantidadDecos.Cero;
                            break;
                        case 1:
                            eCantidadDecos = ECantidadDecos.Uno;
                            break;
                        case 2:
                            eCantidadDecos = ECantidadDecos.Dos;
                            break;
                        case 3:
                            eCantidadDecos = ECantidadDecos.Tres;
                            break;
                        case 4:
                            eCantidadDecos = ECantidadDecos.Cuatro;
                            break;
                        default:
                            eCantidadDecos = ECantidadDecos.Cero;
                            break;
                    }
                    List<ESenialesPremiun> listaSeniales = new List<ESenialesPremiun>();
                    if (dataReader.GetBoolean(7))
                        listaSeniales.Add(ESenialesPremiun.HBO);
                    if (dataReader.GetBoolean(8))
                        listaSeniales.Add(ESenialesPremiun.NBA);
                    if (dataReader.GetBoolean(9))
                        listaSeniales.Add(ESenialesPremiun.Star);
                    if (dataReader.GetBoolean(10))
                        listaSeniales.Add(ESenialesPremiun.Paramount);
                    if (dataReader.GetBoolean(11))
                        listaSeniales.Add(ESenialesPremiun.FutbolArgentino);
                    Servicio servicios = new Servicio(eServicio, eFormaPago, eCantidadDecos, listaSeniales);
                    ClienteDTV usuario = new ClienteDTV(dni, nombre, apellido, direccion, servicios);


                    lista.Add(usuario);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
