using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class Ticket
    {
        public long Id { get; set; }
        public string codigo { get; set; }
        public int NumPersonasIn { get; set; }
        public int NumPersonasOut { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public Ticket(string codigo, DateTime FechaEntrada, int NumPersonaIn) {
            this.codigo = codigo;
            this.FechaEntrada = FechaEntrada;
            this.NumPersonasIn = NumPersonaIn;
        }

        public Ticket()
        {

        }

        public void calcularPrecio(DateTime Inicio, DateTime Fin)
        {

        }
    }
}
