using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;

namespace ControlAforoTFG.ModelosDAO
{
    internal class TicketDAO
    {
        private ConectionDB conexion = new ConectionDB();
        public void guardarTicket(Ticket ticket)
        {
            conexion.GuardarTicket(ticket);
        }
    }
}
