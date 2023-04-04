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

        public Ajustes(string precio_minuto, string precio_primera_media_hora, int descuento) {
            this.precio_minuto = precio_minuto;
            this.precio_primera_media_hora = precio_primera_media_hora;
            this.descuento = descuento;
        }

        public Ajustes()
        {

        }
    }
}
