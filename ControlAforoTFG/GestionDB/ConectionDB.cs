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
            CreateTableTicketIn();
            CreateTableTicketOut();
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
            string createTableQuery = "CREATE TABLE Ajustes (precio_minuto decimal(6,2), precio_primera_media_hora decimal(6,2), descuento int, aforo int)";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();

            string createAjuste = "INSERT INTO Ajustes (precio_minuto, precio_primera_media_hora, descuento, aforo) VALUES (0, 0, 0, 0);";
            SqlCommand saveCommand = new SqlCommand(createAjuste, connection);
            saveCommand.ExecuteNonQuery();
        }

        private void CreateTableTicketIn()
        {
            string createTableQuery = "CREATE TABLE TicketIn (codigo varchar(10) PRIMARY KEY," +
                                                            "num_personas_in int, " +
                                                            "fecha_entrada DATETIME)";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();
        }

        private void CreateTableTicketOut()
        {
            string createTableQuery = "CREATE TABLE TicketOut (id int IDENTITY(1,1) PRIMARY KEY, " +
                                                            "codigo varchar(10)," +
                                                            "num_personas_out int, "+
                                                            "fecha_entrada DATETIME," +
                                                            "fecha_salida DATETIME," +
                                                            "importe decimal(6,2)," +
                                                            "metodo_pago varchar(50))";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();
        }

        public void GuardarTicketIn(TicketIn ticket)
        {
            Open();
            UsingDatabase();
            string saveTicketQuery = "INSERT INTO TicketIn (codigo, fecha_entrada, num_personas_in) VALUES ('" + ticket.codigo + "', " +
                                     "'" + ticket.FechaEntrada.Year + "-" +ticket.FechaEntrada.Month + "-" + ticket.FechaEntrada.Day + 
                                     " " + ticket.FechaEntrada.Hour + ":" + ticket.FechaEntrada.Minute+ ":" + ticket.FechaEntrada.Second + "', '" + ticket.NumPersonasIn + "');";
            SqlCommand saveCommand = new SqlCommand(saveTicketQuery, connection);
            saveCommand.ExecuteNonQuery();

            Close();
        }

        public void GuardarTicketOut(TicketOut ticket)
        {
            Open();
            UsingDatabase();
            string saveTicketQuery = "INSERT INTO TicketOut (codigo, num_personas_out, fecha_entrada, fecha_salida, importe, metodo_pago ) VALUES ('" + ticket.codigo + "', " + ticket.NumPersonasOut + "," +
                                     "'" + ticket.FechaEntrada.Year + "-" + ticket.FechaEntrada.Month + "-" + ticket.FechaEntrada.Day + 
                                     " " + ticket.FechaEntrada.Hour + ":" + ticket.FechaEntrada.Minute + ":" + ticket.FechaEntrada.Second+ "',"+
                                     "'" + ticket.FechaSalida.Year + "-" + ticket.FechaSalida.Month + "-" + ticket.FechaSalida.Day +
                                     " " + ticket.FechaSalida.Hour + ":" + ticket.FechaSalida.Minute + ":" + ticket.FechaSalida.Second + "'," +
                                     " " + ticket.Importe.ToString().Replace(",", ".") + ", '" +ticket.MetodoPago+ "');";
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
                                          "descuento = '" + ajustes.descuento + "', aforo = '" + ajustes.aforo +"'";
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
                        ajustes.aforo = Convert.ToInt32(reader["aforo"]);
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

        public int calcularAforo()
        {
            int aforoDisponible = 0;
            var personasIn = 0;
            var personasOut = 0;
            int aforoMax = 0;

            try
            {
                Open();
                UsingDatabase();

                /*Obtenemos num de personas dentro*/
                //string calculaAforo = "SELECT 'Total' AS codigo, SUM(CASE WHEN rn = 1 THEN num_personas_in ELSE 0 END) AS total_personas_in, SUM(num_personas_out) AS total_personas_out FROM ( SELECT codigo, num_personas_in, num_personas_out, ROW_NUMBER() OVER (PARTITION BY codigo ORDER BY id) AS rn FROM Ticket WHERE YEAR(fecha_entrada) = YEAR(GETDATE()) AND MONTH(fecha_entrada) = MONTH(GETDATE()) AND DAY(fecha_entrada) = DAY(GETDATE())) AS subquery GROUP BY codigo WITH ROLLUP HAVING GROUPING_ID(codigo) = 1;";
                string getNumPersonasIn = "SELECT sum(num_personas_in) AS total_personas_in FROM TicketIn";

                SqlCommand commandIn = new SqlCommand(getNumPersonasIn, connection);

                using (SqlDataReader reader = commandIn.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                        if (reader.IsDBNull(reader.GetOrdinal("total_personas_in")))
                        {
                            personasIn = 0;
                        } else {
                            personasIn = Convert.ToInt32(reader["total_personas_in"]);
                        }
                    }
                }

                /*Obtenemos numero de personas que salen*/
                string getNumPersonasOut = "SELECT sum(num_personas_out) AS total_personas_out FROM TicketOut";

                SqlCommand commandOut = new SqlCommand(getNumPersonasOut, connection);

                using (SqlDataReader reader = commandOut.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        if (reader.IsDBNull(reader.GetOrdinal("total_personas_out")))
                        {
                            personasOut = 0;
                        }
                        else
                        {
                            personasOut = Convert.ToInt32(reader["total_personas_out"]);
                        }
                    }
                }

                /*Obtenemos aforo maximo*/
                string obtenerAforoMax = "SELECT aforo FROM Ajustes";

                SqlCommand command2 = new SqlCommand(obtenerAforoMax, connection);

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        aforoMax = Convert.ToInt32(reader["aforo"]);
                    }
                }

                /*Calculamos aforo disponible*/
                aforoDisponible = aforoMax - (personasIn - personasOut);

                Close();
            }
            catch (Exception)
            {
                Close();
            }

            return aforoDisponible;
        }

        public TicketOut ExisteTicketIn(string codigo)
        {
            Open();
            UsingDatabase();

            TicketOut ticket = new TicketOut();
            string obtenerTicket = "SELECT * from TicketIn WHERE codigo = '" +codigo+ "'";

            SqlCommand command = new SqlCommand(obtenerTicket, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    ticket.codigo = codigo;
                    ticket.FechaEntrada = Convert.ToDateTime(reader["fecha_entrada"]);
                    ticket.FechaSalida = DateTime.Now;   
                } else
                {
                    ticket = null;
                }
            }

            Close();

            return ticket;
        }

        public bool checkSalida(TicketOut ticketOut)
        {
            Open();
            UsingDatabase();

            int genteIn = 0;
            int genteOutNow = ticketOut.NumPersonasOut;
            int genteOutBefore = 0;

            string getGenteIn = "SELECT SUM(num_personas_in) AS num_personas_in FROM TicketIn where codigo = '"+ticketOut.codigo+"'";

            SqlCommand command = new SqlCommand(getGenteIn, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if(reader.Read())
                {
                    genteIn = Convert.ToInt32(reader["num_personas_in"]);
                }
            }

            string getGenteOutBefore = "SELECT SUM(num_personas_out) AS num_personas_out FROM TicketOut where codigo = '"+ticketOut.codigo+"'";

            SqlCommand command2 = new SqlCommand(getGenteOutBefore, connection);

            using (SqlDataReader reader = command2.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (reader.IsDBNull(reader.GetOrdinal("num_personas_out")))
                    {
                        genteOutBefore = 0;
                    } else
                    {
                        genteOutBefore = Convert.ToInt32(reader["num_personas_out"]);
                    }
                        
                }
            }

            if (genteOutNow + genteOutBefore > genteIn)
            {
                return false;
            }

            Close();
            return true;
        }

        public void BorrarRegistroOut(int id)
        {
            Open();
            UsingDatabase();

            // Eliminar la fila de la base de datos
            string query = "DELETE FROM ticketOut WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Close();
        }

        public void BorrarRegistroIn(string codigo)
        {
            Open();
            UsingDatabase();

            // Eliminar la fila de la base de datos
            string query = "DELETE FROM ticketIn WHERE codigo = '" +codigo +"'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            string query2 = "DELETE FROM ticketOut WHERE codigo = '" + codigo + "'";
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.ExecuteNonQuery();

            Close();
        }

        public List<TicketOut> DevolverInforme(string consulta)
        {
            List<TicketOut> listaTickets = new List<TicketOut>();
            Open();
            UsingDatabase();

            SqlCommand command = new SqlCommand(consulta, connection);
            command.ExecuteNonQuery();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    TicketOut ticket = new TicketOut();

                    /*Campo Codigo*/
                    if (reader.IsDBNull(reader.GetOrdinal("codigo")))
                    {
                        ticket.codigo = null;
                    }
                    else
                    {
                        ticket.codigo = reader.GetString(reader.GetOrdinal("codigo"));
                    }

                    /*Campo Num_personas_out*/
                    if (reader.IsDBNull(reader.GetOrdinal("num_personas_out")))
                    {
                        ticket.NumPersonasOut = 0;
                    }
                    else
                    {
                        ticket.NumPersonasOut = reader.GetInt32(reader.GetOrdinal("num_personas_out"));
                    }

                    /*Campo fecha_entrada*/
                    ticket.FechaEntrada = Convert.ToDateTime(reader["fecha_entrada"]);

                    /*Campo fecha_salida*/
                    ticket.FechaSalida = Convert.ToDateTime(reader["fecha_salida"]);

                    /*Campo importe*/
                    if (reader.IsDBNull(reader.GetOrdinal("importe")))
                    {
                        ticket.Importe = 0;
                    }
                    else
                    {
                        ticket.Importe = reader.GetDecimal(reader.GetOrdinal("importe"));
                    }

                    /*Campo metodo_pago*/
                    if (reader.IsDBNull(reader.GetOrdinal("metodo_pago")))
                    {
                        ticket.MetodoPago = null;
                    }
                    else
                    {
                        ticket.MetodoPago = reader.GetString(reader.GetOrdinal("metodo_pago"));
                    }

                    listaTickets.Add(ticket);
                }
            }

            Close();
            return listaTickets;
        }
    }
}
