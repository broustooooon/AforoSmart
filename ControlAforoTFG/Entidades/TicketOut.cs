using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.Entidades
{
    internal class TicketOut
    {
        public int id {  get; set; }
        public string codigo { get; set; }
        public int num_personas_out { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public decimal importe { get; set; }
        public string metodo_pago { get; set; }
        public string estado { get; set; }

        public TicketOut() {
        
        }

        public TicketOut(string codigo, int NumPersonasOut, DateTime FechaSalida, string MetodoPago)
        {
            this.codigo = codigo;
            this.num_personas_out = NumPersonasOut;
            this.fecha_salida = FechaSalida;
            this.metodo_pago = MetodoPago;
            this.estado = "abierto";
        }

        public decimal calcularImporte(Ajustes ajustes)
        {
            decimal importe = 0;
            decimal precio_primera_media_hora = decimal.Parse(ajustes.precio_primera_media_hora, CultureInfo.InvariantCulture);
            decimal precio_minuto = decimal.Parse(ajustes.precio_minuto, CultureInfo.InvariantCulture);
            int descuento = ajustes.descuento;

            // Calcular la diferencia de tiempo entre la fecha de entrada y la fecha de salida en minutos
            TimeSpan tiempoTranscurrido = this.fecha_salida - this.fecha_entrada;
            int minutosTranscurridos = Convert.ToInt32(tiempoTranscurrido.TotalMinutes);

            // Calcular el importe en base a los precios establecidos y la diferencia de tiempo
            if (minutosTranscurridos <= 30)
            {
                importe = precio_primera_media_hora;
            }
            else
            {
                importe = precio_primera_media_hora + ((minutosTranscurridos - 30) * precio_minuto);
            }

            // Aplicar el descuento si corresponde
            if (descuento != 0)
            {
                decimal descuentoPorcentual = Convert.ToDecimal(descuento) / 100;
                decimal importeConDescuento = importe - (importe * descuentoPorcentual);
                importe = importeConDescuento * this.num_personas_out;
            }

            return importe;
        }
    }
}
