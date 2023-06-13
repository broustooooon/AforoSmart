using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class RegistroCaja
    {
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public decimal dinero_introducido { get; set; }
        public decimal efectivo { get; set; }
        public decimal otros { get; set; }

        public RegistroCaja(DateTime fecha, string descripcion, decimal dinero_introducido, decimal efectivo, decimal otros) { 
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.dinero_introducido = dinero_introducido;
            this.efectivo = efectivo;
            this.otros = otros;
        }
    }
}
