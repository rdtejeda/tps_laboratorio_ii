using System;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ReclamosDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static ReclamosDAO()
        {
            connectionString = @"Server=.;Database=TEJEDA2C-TPF; Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        /// <summary>
        /// Busca cantidad de registros para oorgar nu emr de reclamo no repetido
        /// </summary>
        /// <returns></returns>
        public static int UltimoNumeroDeReclamo()
        {
            int ultimoReclamo;
            try
            {
                string query = "SELECT COUNT(NumeroReclamo) FROM [Reclamos]";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                ultimoReclamo = dataReader.GetInt32(0);

                return ultimoReclamo;
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
        /// Gurada nuevo reclamo en base da tos sql
        /// </summary>
        /// <param name="nuevoReclamo"></param>
        public static void Guardar(Reclamo nuevoReclamo)
        {
            try
            {
                if (nuevoReclamo.NumeroReclamo > UltimoNumeroDeReclamo())
                {
                    connection.Open();
                    string query = "INSERT INTO Reclamos (DniCliente, EstaSolucionado) VALUES (@DniCliente, @EstaSolucionado)";
                    command.CommandText = query;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("DniCliente", int.Parse(nuevoReclamo.DniClienteReclama));
                    if (nuevoReclamo.EstaSolucionado)
                    {
                        command.Parameters.AddWithValue("EstaSolucionado", 1);

                    }
                    else
                    {
                        command.Parameters.AddWithValue("EstaSolucionado", 0);
                    }
                    command.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE Reclamos SET EstaSolucionado = @EstaSolucionado WHERE DniCliente = " + nuevoReclamo.DniClienteReclama + " and NumeroReclamo = " + nuevoReclamo.NumeroReclamo.ToString();// @DniCliente";
                                                                                                                                                                                                                   //   "UPDATE Reclamos SET EstaSolucionado = 1 WHERE DniCliente = 18223125 and NumeroReclamo = 1"
                    connection.Open();
                    command.CommandText = query;
                    command.Parameters.Clear();
                    if (nuevoReclamo.EstaSolucionado)
                    {
                        command.Parameters.AddWithValue("EstaSolucionado", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("EstaSolucionado", 0);
                    }
                    command.ExecuteNonQuery();
                }
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
        /// busca y reclamo por su numero
        /// </summary>
        /// <param name="reclamo"></param>
        /// <returns>El reclamo</returns>
        public static Reclamo BuscarReclamo(int reclamo)
        {
            Reclamo reclamoAux;
            try
            {
                string query = "SELECT* FROM Reclamos where NumeroReclamo=" + reclamo.ToString(); //"@NumeroReclamo";//"SELECT COUNT(NumeroReclamo) FROM [Reclamos]";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                reclamoAux = new Reclamo(reclamo, dataReader.GetString(1));
                reclamoAux.EstaSolucionado = dataReader.GetBoolean(2);

                return reclamoAux;
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