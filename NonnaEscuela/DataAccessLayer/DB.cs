using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using EntityLayer;


namespace DataAccessLayer
{
    public class DB
    {
     
        /// <summary>
        /// Return the connection string from the config file
        /// </summary>
        private static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Pramirez_escuelaConnection"].ToString();
            }
        }

        /// <summary>
        /// Returns an opened connection to the caller
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetSqlConnection()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error al obtener la conexión: "+ e.Message);
                conn.Close();
            }
            return conn;
        }

        public _User CheckLogin(string login, string password)
        {
            MySqlCommand command;
            _User usuario = new _User();

            MySqlConnection connection = GetSqlConnection();
            
            command = new MySqlCommand(Qrys.QryLogin, connection);
            command.Parameters.AddWithValue("@logname", login);
            using (connection)
            {
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        usuario.ID = Convert.ToInt32(reader["ID_PERSONA"]);
                        usuario.Nombre = reader["NOMBRE"].ToString();
                        usuario.ApellidoP = reader["APELLIDO_PATERNO"].ToString();
                        usuario.ApellidoM = reader["APELLIDO_MATERNO"].ToString();
                        usuario.Email = reader["EMAIL"].ToString();
                        usuario.Sexo = reader["SEXO"].ToString();
                        usuario.Nacionalidad = reader["NACIONALIDAD"].ToString();
                        usuario.LogName = reader["LOG_NAME"].ToString();
                        usuario.Password = reader["PASSWORD"].ToString();
                        usuario.FechaIngreso = (DateTime)reader["FECHA_INGRESO"];
                        usuario.Estatus = reader["STATUS"].ToString();
                        usuario.IDRol = reader["ID_ROL"].ToString();
                        usuario.Ingresa = (usuario.Estatus == "A");
                    }
                        
                    reader.Close();
                }
                catch (Exception ex)
                {
                    LogFile.WriteLogFile("Error en login: " + ex.Message);
                }
            }
            return usuario;
        }


    }
}
