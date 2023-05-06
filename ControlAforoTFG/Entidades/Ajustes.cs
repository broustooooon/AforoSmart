using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class Ajustes
    {
        public string precio_minuto { get; set; }
        public string precio_primera_media_hora { get; set; }
        public int descuento { get; set; }
        public int aforo { get; set; }
        public string dinero_introducido { get; set; }

        public Ajustes(string precio_minuto, string precio_primera_media_hora, int descuento, int aforo, string dinero_introducido) {
            this.precio_minuto = precio_minuto;
            this.precio_primera_media_hora = precio_primera_media_hora;
            this.descuento = descuento;
            this.aforo = aforo;
            this.dinero_introducido = dinero_introducido;
        }

        public Ajustes()
        {

        }
    }
}
