using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class Ticket
    {
        public string Id { get; set; }
        public int NumPersonas { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public Ticket(string Id, DateTime FechaEntrada) {
            this.Id = Id;
            this.FechaEntrada = FechaEntrada;
        }

        public Ticket()
        {
        }

        public void calcularPrecio(DateTime Inicio, DateTime Fin)
        {

        }
    }
}
