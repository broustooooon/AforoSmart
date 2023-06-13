using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class TicketIn
    {
        public string codigo { get; set; }
        public int NumPersonasIn { get; set; }
        public DateTime FechaEntrada { get; set; }

        public TicketIn(string codigo, DateTime FechaEntrada, int NumPersonaIn) {
            this.codigo = codigo;
            this.FechaEntrada = FechaEntrada;
            this.NumPersonasIn = NumPersonaIn;
        }
    }
}
