using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuariosDTVDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static UsuariosDTVDAO()
        {
            connectionString = @"Server=.;Database=TEJEDA2C-TPF; Trusted_Connection=True;";
            connection = new SqlConnection(UsuariosDTVDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        /// <summary>
        /// Lee los usuarios habilitados para ingresar a la app
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public static List<UsuarioDTV> Leer()
        {
            List<UsuarioDTV> lista = new List<UsuarioDTV>();
            try
            {
                string query = "SELECT * FROM Usuarios";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string dni = dataReader.GetInt32(0).ToString();
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string nombreUsuario = dataReader.GetString(3);
                    string passwword = dataReader.GetString(4);

                    UsuarioDTV usuario = new UsuarioDTV(dni, nombre, apellido, nombreUsuario, passwword);

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
