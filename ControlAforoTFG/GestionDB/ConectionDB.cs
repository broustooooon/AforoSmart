using ControlAforoTFG.Entidades;
using ControlAforoTFG.Formularios.Consultas;
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
            CreateTableIncidencias();
            createTableRegistroCaja();
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
            string createTableQuery = "CREATE TABLE Ajustes (precio_minuto decimal(6,2), " +
                                      "precio_primera_media_hora decimal(6,2), " +
                                      "descuento int, " +
                                      "aforo int, "+
                                      "dinero_introducido decimal(6,2)," +
                                      "estado_caja varchar(50))";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();

            string createAjuste = "INSERT INTO Ajustes (precio_minuto, precio_primera_media_hora, descuento, aforo, dinero_introducido, estado_caja) VALUES (0, 0, 0, 0, 0, 'cerrada');";
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
                                                            "metodo_pago varchar(50)," +
                                                            "estado varchar(50) DEFAULT 'abierto')";
            SqlCommand command2 = new SqlCommand(createTableQuery, connection);
            command2.ExecuteNonQuery();
        }

        private void CreateTableIncidencias()
        {
            string createTableQuery = "CREATE TABLE Incidencias (id int IDENTITY(1,1) PRIMARY KEY, " +
                                                            "fecha DATETIME," +
                                                            "descripcion varchar(50))";

            SqlCommand command = new SqlCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        private void createTableRegistroCaja()
        {
            string createTableQuery = "CREATE TABLE RegistroCaja (id int IDENTITY(1,1) PRIMARY KEY, " +
                                                            "fecha DATETIME," +
                                                            "descripcion varchar(50)," +
                                                            "dinero_introducido decimal(6,2)," +
                                                            "efectivo decimal(6,2)," +
                                                            "otros decimal(6,2)," +
                                                            "total AS (dinero_introducido + efectivo + otros)PERSISTED)";

            SqlCommand command = new SqlCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
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
            string saveTicketQuery = "INSERT INTO TicketOut (codigo, num_personas_out, fecha_entrada, fecha_salida, importe, metodo_pago ) VALUES ('" + ticket.codigo + "', " + ticket.num_personas_out + "," +
                                     "'" + ticket.fecha_entrada.Year + "-" + ticket.fecha_entrada.Month + "-" + ticket.fecha_entrada.Day + 
                                     " " + ticket.fecha_entrada.Hour + ":" + ticket.fecha_entrada.Minute + ":" + ticket.fecha_entrada.Second+ "',"+
                                     "'" + ticket.fecha_salida.Year + "-" + ticket.fecha_salida.Month + "-" + ticket.fecha_salida.Day +
                                     " " + ticket.fecha_salida.Hour + ":" + ticket.fecha_salida.Minute + ":" + ticket.fecha_salida.Second + "'," +
                                     " " + ticket.importe.ToString().Replace(",", ".") + ", '" +ticket.metodo_pago+ "');";
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
                                          "descuento = '" + ajustes.descuento + "', aforo = '" + ajustes.aforo +"', dinero_introducido = '" + ajustes.dinero_introducido.Replace(',', '.') + "'";
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
                        ajustes.dinero_introducido = Convert.ToString(reader["dinero_introducido"]).Replace(',', '.');
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
                    ticket.fecha_entrada = Convert.ToDateTime(reader["fecha_entrada"]);
                    ticket.fecha_salida = DateTime.Now;   
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
            int genteOutNow = ticketOut.num_personas_out;
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

                    /*Campo id*/
                    if (reader.IsDBNull(reader.GetOrdinal("id")))
                    {
                        ticket.id = 0;
                    }
                    else
                    {
                        ticket.id = reader.GetInt32(reader.GetOrdinal("id"));
                    }

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
                        ticket.num_personas_out = 0;
                    }
                    else
                    {
                        ticket.num_personas_out = reader.GetInt32(reader.GetOrdinal("num_personas_out"));
                    }

                    /*Campo fecha_entrada*/
                    ticket.fecha_entrada = Convert.ToDateTime(reader["fecha_entrada"]);

                    /*Campo fecha_salida*/
                    ticket.fecha_salida = Convert.ToDateTime(reader["fecha_salida"]);

                    /*Campo importe*/
                    if (reader.IsDBNull(reader.GetOrdinal("importe")))
                    {
                        ticket.importe = 0;
                    }
                    else
                    {
                        ticket.importe = reader.GetDecimal(reader.GetOrdinal("importe"));
                    }

                    /*Campo metodo_pago*/
                    if (reader.IsDBNull(reader.GetOrdinal("metodo_pago")))
                    {
                        ticket.metodo_pago = null;
                    }
                    else
                    {
                        ticket.metodo_pago = reader.GetString(reader.GetOrdinal("metodo_pago"));
                    }

                    /*Campo Estado*/
                    if (reader.IsDBNull(reader.GetOrdinal("estado")))
                    {
                        ticket.estado = null;
                    }
                    else
                    {
                        ticket.estado = reader.GetString(reader.GetOrdinal("estado"));
                    }

                    listaTickets.Add(ticket);
                }
            }

            Close();
            return listaTickets;
        }

        public void cerrarTicket()
        {
            Open();
            UsingDatabase();

            string cerrarTicket = "UPDATE TicketOut SET estado = 'cerrado' WHERE estado = 'abierto'";
            SqlCommand cerrarTicketCommand = new SqlCommand(cerrarTicket, connection);
            cerrarTicketCommand.ExecuteNonQuery();

            Close();
        }

        public bool ComprobarCajaAbierta()
        {
            Open();
            UsingDatabase();

            string comprobarCajaAbiertaQuery = "SELECT * FROM TicketOut WHERE estado = 'abierto'";
            SqlCommand comprobarCajaAbiertaCommand = new SqlCommand(comprobarCajaAbiertaQuery, connection);
            comprobarCajaAbiertaCommand.ExecuteNonQuery();

            bool existeCajaAbierta = false;

            using (SqlDataReader reader = comprobarCajaAbiertaCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    existeCajaAbierta = true;
                }
            }

            Close();

            return existeCajaAbierta;
        }

        public void CambiarDineroCaja(string dinero)
        {
            Open();
            UsingDatabase();

            string comprobarCajaAbiertaQuery = "UPDATE Ajustes SET dinero_introducido = '" + dinero.Replace(',', '.') + "'";
            SqlCommand comprobarCajaAbiertaCommand = new SqlCommand(comprobarCajaAbiertaQuery, connection);
            comprobarCajaAbiertaCommand.ExecuteNonQuery();


            Close();
        }

        public string[] CalcularCierreCaja()
        {
            Open();
            UsingDatabase();

            string[] total = new string[3];

            /*Obtener Dinero de los Tickets Efectivo*/
            string dineroEfectivoQuery = "SELECT sum(importe) AS total FROM TicketOut WHERE estado = 'abierto' AND metodo_pago = 'Efectivo'";
            SqlCommand dineroEfectivoCommand = new SqlCommand(dineroEfectivoQuery, connection);
            dineroEfectivoCommand.ExecuteNonQuery();

            using (SqlDataReader reader = dineroEfectivoCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    total[0] = Convert.ToString(reader["total"]).Replace(',', '.');
                    if (total[0] == "")
                    {
                        total[0] = "0";
                    }
                }
            }

            /*Obtener Dinero de los Tickets Otros metodos != efectivo */
            string otrosMetodosQuery = "SELECT sum(importe) AS total FROM TicketOut WHERE estado = 'abierto' AND metodo_pago != 'Efectivo'";
            SqlCommand otrosMetodosCommand = new SqlCommand(otrosMetodosQuery, connection);
            otrosMetodosCommand.ExecuteNonQuery();

            using (SqlDataReader reader = otrosMetodosCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    total[1] = Convert.ToString(reader["total"]).Replace(',', '.');
                    if (total[1] == "")
                    {
                        total[1] = "0";
                    }
                }
            }

            /*Obtener Dinero de Ajustes*/
            string dineroAjustesQuery = "SELECT dinero_introducido AS total FROM Ajustes";
            SqlCommand dineroAjustesCommand = new SqlCommand(dineroAjustesQuery, connection);
            dineroAjustesCommand.ExecuteNonQuery();

            using (SqlDataReader reader = dineroAjustesCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    total[2] = Convert.ToString(reader["total"]).Replace(',', '.');
                }
            }


            Close();
            return total;
        }

        public void AbrirCaja()
        {
            Open();
            UsingDatabase();

            string saveAjustesQuery = "UPDATE Ajustes SET estado_caja = 'abierta'";
            SqlCommand ajustesCommand = new SqlCommand(saveAjustesQuery, connection);
            ajustesCommand.ExecuteNonQuery();

            Close();
        }

        public void CerrarCaja()
        {
            Open();
            UsingDatabase();

            string cerrarCajaQuery = "UPDATE Ajustes SET estado_caja = 'cerrada'";
            SqlCommand cerrarCajaCommand = new SqlCommand(cerrarCajaQuery, connection);
            cerrarCajaCommand.ExecuteNonQuery();

            Close();
        }

        public bool EstadoCaja()
        {
            Open();
            UsingDatabase();

            string estadoCajaQuery = "SELECT estado_caja FROM Ajustes";
            SqlCommand estadoCajaCommand = new SqlCommand(estadoCajaQuery, connection);
            estadoCajaCommand.ExecuteNonQuery();

            bool abierta = false;

            using (SqlDataReader reader = estadoCajaCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    string estado = Convert.ToString(reader["estado_caja"]);
                    if (estado.Equals("abierta")) {
                        abierta = true;
                    }
                }
            }

            Close();
            return abierta;
        }

        public void insertarIncidencia(Incidencia incidencia)
        {
            Open();
            UsingDatabase();
            string saveTicketQuery = "INSERT INTO Incidencias (fecha, descripcion) VALUES ('" + incidencia.fecha.Year + "-" + incidencia.fecha.Month + "-" + incidencia.fecha.Day +
                                     " " + incidencia.fecha.Hour + ":" + incidencia.fecha.Minute + ":" + incidencia.fecha.Second + "', " +
                                     "'" + incidencia.descripcion + "');";
            SqlCommand saveCommand = new SqlCommand(saveTicketQuery, connection);
            saveCommand.ExecuteNonQuery();

            Close();
        }

        public void insertarRegistroCaja(Entidades.RegistroCaja registro)
        {
            Open();
            UsingDatabase();
            string saveTicketQuery = "INSERT INTO RegistroCaja (fecha, descripcion, efectivo, otros) VALUES ('" + registro.fecha.Year + "-" + registro.fecha.Month + "-" + registro.fecha.Day +
                                     " " + registro.fecha.Hour + ":" + registro.fecha.Minute + ":" + registro.fecha.Second + "', " +
                                     "'" + registro.descripcion + "', '"+registro.efectivo.ToString().Replace(",", ".") + "', '"+registro.otros.ToString().Replace(",", ".") + "');";
            SqlCommand saveCommand = new SqlCommand(saveTicketQuery, connection);
            saveCommand.ExecuteNonQuery();

            Close();
        }
    }
}
