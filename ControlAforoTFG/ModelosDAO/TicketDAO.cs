using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;

namespace ControlAforoTFG.ModelosDAO
{
    internal class TicketDAO
    {
        private ConectionDB conexion = new ConectionDB();
        public void guardarTicketIn(TicketIn ticket)
        {
            conexion.GuardarTicketIn(ticket);
        }

        public void guardarTicketOut(TicketOut ticket)
        {
            conexion.GuardarTicketOut(ticket);
        }
    }
}
