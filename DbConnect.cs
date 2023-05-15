using MySql.Data.MySqlClient;
using System;

namespace Buscador3
{
    class DbConnect
    {
        public MySqlConnection ConnDb()
        {
            MySqlConnection connect = new MySqlConnection(
                "server = localhost;" +
                "Port = 3306;" +
                "Uid = buscador_dba;" +
                "pwd = buscador_dba" +
                "Database = buscador;" +
                "SSL Mode=None"
            );
            try
            {
                connect.Open();
                return connect;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public void InsertDb(string query)
        {
            MySqlConnection connect = new MySqlConnection(
                "Server = localhost;" +
                "Port = 3306;" +
                "Uid = buscador_dba;" +
                "pwd = buscador_dba;" +
                "Database = buscador;" +
                "SSL Mode=None"
            );
            MySqlCommand command;
            try
            {
                connect.Open();
                command = new MySqlCommand(query, connect);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            connect.Close();
        }

        public MySqlDataReader SelectPalabrasRepetidas()
        {
            MySqlConnection connect = new MySqlConnection(
                "Server = localhost;" +
                "Port = 3306;" +
                "Uid = buscador_dba;" +
                "pwd = buscador_dba;" +
                "Database = buscador;" +
                "SSL Mode=None"
            );
            MySqlCommand command;
            String query;
            query = "SELECT " +
                      "desc_palabra AS Palabra, " +
                      "count(desc_palabra) Repeticiones, " +
                      "id_archivo AS \"Primera Coincidencia\" " +
                    "FROM " +
                      "palabras " +
                    "GROUP BY " +
                      "desc_palabra " +
                    "HAVING " +
                      "Repeticiones >= 1 " +
                    "ORDER BY " +
                      "Repeticiones DESC";
            try
            {
                connect.Open();
                command = new MySqlCommand(query, connect);
                MySqlDataReader reader = command.ExecuteReader();
                //connect.Close();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public MySqlDataReader SelectPalabra(string palabra)
        {
            MySqlConnection connect = new MySqlConnection(
                "Server = localhost;" +
                "Port = 3306;" +
                "Uid = buscador_dba;" +
                "pwd = buscador_dba;" +
                "Database = buscador;" +
                "SSL Mode=None"
            );
            MySqlCommand command;
            String query;
            query = "SELECT " +
                      "desc_palabra AS Palabra, " +
                      "id_archivo, " +
                      "COUNT(id_archivo) " +
                    "FROM " +
                      "palabras " +
                    "WHERE " +
                      "desc_palabra = '" + palabra +
                    "' GROUP BY " +
                      "id_archivo";
            try
            {
                connect.Open();
                command = new MySqlCommand(query, connect);
                MySqlDataReader reader = command.ExecuteReader();
                //connect.close()
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }

    //System.Data.DataRow[] foundRows;
    //DataSet dataSet = new DataSet("Palabras");
    //MySqlCommand consulta = new MySqlCommand(query, connect);
    //datos.TableMappgings.Add("Table", "Palabras");
    /*System.Data.DataTable tabla = new DataTable();
     * MySqlDataAdapter datos = new MySqlDataAdapter(query, connect);
     * datos.Fill(tabla);*/
}
