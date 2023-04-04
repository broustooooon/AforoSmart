using ControlAforoTFG.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Modelos_DAO
{
    internal class ConectionDB
    {
        private string connectionString;
        private SqlConnection connection;

        public ConectionDB()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";
            // Initial Catalog=master;
            connection = new SqlConnection(connectionString);
        }

        private void Open()
        {
            connection.Open();
        }

        private void Close()
        {
            connection.Close();
        }
        
        public void ScriptBaseDeDatos()
        {
            Open();
            CreateDatabase();
            CreateTableTicket();
            CreateTableAjustes();
            Close();
        }

        private void CreateDatabase()
        {
            string deleteDatabaseQuery = "DROP DATABASE IF EXISTS ControlAforo";
            SqlCommand deleteCommand = new SqlCommand(deleteDatabaseQuery, connection);
            deleteCommand.ExecuteNonQuery();

            string createDatabaseQuery = "CREATE DATABASE ControlAforo";
            SqlCommand createCommand = new SqlCommand(createDatabaseQuery, connection);
            createCommand.ExecuteNonQuery();

            UsingDatabase();
        }

        private void UsingDatabase()
        {
            string useDatabaseQuery = "USE ControlAforo";
            SqlCommand useCommand = new SqlCommand(useDatabaseQuery, connection);
            useCommand.ExecuteNonQuery();
        }

        private void CreateTableAjustes()
        {
            string createTableQuery = "CREATE TABLE Ajustes (precio_minuto decimal(4,2), precio_primera_media_hora decimal(4,2), descuento int)";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();

            string createAjuste = "INSERT INTO Ajustes (precio_minuto, precio_primera_media_hora, descuento) VALUES (0, 0, 0);";
            SqlCommand saveCommand = new SqlCommand(createAjuste, connection);
            saveCommand.ExecuteNonQuery();
        }

        private void CreateTableTicket()
        {
            string createTableQuery = "CREATE TABLE Ticket (id int IDENTITY(1,1) PRIMARY KEY, " +
                                                            "codigo varchar(10)," +
                                                            "num_personas_in int, " +
                                                            "num_personas_out int, " +
                                                            "fecha_entrada DATETIME, " +
                                                            "fecha_salida DATETIME)";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();
        }

        public void GuardarTicket(Ticket ticket)
        {
            Open();
            UsingDatabase();
            string saveTicketQuery = "INSERT INTO Ticket (codigo, fecha_entrada, num_personas_in) VALUES ('" + ticket.codigo + "', '" + ticket.FechaEntrada + "', '" + ticket.NumPersonasIn + "');";
            SqlCommand saveCommand = new SqlCommand(saveTicketQuery, connection);
            saveCommand.ExecuteNonQuery();

            Close();
        }

        public bool GuardarAjustes(Ajustes ajustes)
        {
            try
            {
                Open();
                UsingDatabase();

                string saveAjustesQuery = "UPDATE Ajustes SET precio_minuto = '" + ajustes.precio_minuto.Replace(',', '.') + "', " +
                                          "precio_primera_media_hora = '" + ajustes.precio_primera_media_hora.Replace(',', '.') + "', " +
                                          "descuento = '" + ajustes.descuento + "'";
                SqlCommand ajustesCommand = new SqlCommand(saveAjustesQuery, connection);
                ajustesCommand.ExecuteNonQuery();

                Close();
            }
            catch (Exception)
            {
                Close();
                return false;
            }
            return true;
        }


        public Ajustes CargarAjustes()
        {
            Ajustes ajustes = new Ajustes();

            try
            {
                Open();
                UsingDatabase();

                string loadAjustesQuery = "SELECT * FROM Ajustes";
                SqlCommand command = new SqlCommand(loadAjustesQuery, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ajustes.precio_minuto = Convert.ToString(reader["precio_minuto"]).Replace(',', '.');
                        ajustes.precio_primera_media_hora = Convert.ToString(reader["precio_primera_media_hora"]).Replace(',', '.');
                        ajustes.descuento = Convert.ToInt32(reader["descuento"]);
                    }
                }

                Close();
            }
            catch (Exception)
            {
                ajustes = null;
                Close();
            }
            return ajustes;
        }
    }
}
