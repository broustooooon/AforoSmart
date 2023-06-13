using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class Incidencia
    {
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }

        public Incidencia(DateTime fecha, string descripcion) {
            this.fecha = fecha;
            this.descripcion = descripcion;
        }
    }
}
