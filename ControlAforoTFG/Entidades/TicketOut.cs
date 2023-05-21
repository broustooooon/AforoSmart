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
        public int id { get; set; }
        public string codigo { get; set; }
        public int num_personas_out { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public decimal importe { get; set; }
        public decimal descuento { get; set; }
        public string tipo_descuento { get; set; }
        public string metodo_pago { get; set; }
        public string estado { get; set; }

        public TicketOut()
        {

        }

        public TicketOut(string codigo, int NumPersonasOut, DateTime FechaSalida, string MetodoPago)
        {
            this.codigo = codigo;
            this.num_personas_out = NumPersonasOut;
            this.fecha_salida = FechaSalida;
            this.metodo_pago = MetodoPago;
            this.estado = "abierto";
            this.descuento = 0;
        }

        public decimal calcularImporte(Ajustes ajustes, string tipoDescuento = null, int porcentajeDescuento = 0, int numTickets = 0)
        {
            decimal importe = 0;
            decimal precio_primera_media_hora = decimal.Parse(ajustes.precio_primera_media_hora, CultureInfo.InvariantCulture);
            decimal precio_minuto = decimal.Parse(ajustes.precio_minuto, CultureInfo.InvariantCulture);
            int descuento = ajustes.descuento;

            if(tipoDescuento.Equals("Sin Descuento"))
            {
                descuento = 0;
            }

            else if (tipoDescuento.Equals("2x1") && numTickets >= 2)
            {
                if (numTickets % 2 == 0)
                {
                    descuento = 50;
                } 
                else
                {
                    numTickets -= numTickets / 2;
                }
            }

            else if (tipoDescuento.Equals("3x2") && numTickets >= 3)
            {
                if (numTickets % 3 == 0)
                {
                    descuento = 33;
                }
                else
                {
                    numTickets -= numTickets / 3;
                }
            }

            else if (tipoDescuento.Equals("Introducir %"))
            {
                descuento = porcentajeDescuento;
            }

            // Calcular la diferencia de tiempo entre la fecha de entrada y la fecha de salida en minutos
            TimeSpan tiempoTranscurrido = this.fecha_salida - this.fecha_entrada;
            int minutosTranscurridos = Convert.ToInt32(tiempoTranscurrido.TotalMinutes);

            // Dividir el tiempo transcurrido en tramos de 60 minutos
            int horas = (minutosTranscurridos + 59) / 60;

            /*
            if(horas == 0)
            {
                importe = precio_primera_media_hora;
            }
            */
            
            // Calcular el importe en base a los precios establecidos y la diferencia de tiempo para cada tramo
            for (int i = 0; i < horas; i++)
            {
                int minutosTramoActual = Math.Min(minutosTranscurridos - (i * 60), 60);

                if (i == 0 && minutosTramoActual <= 30)
                {
                    // Primera HORA y tiempo inferior o igual a 30 minutos
                    importe += precio_primera_media_hora;
                    //return importe * numTickets;
                }

                if (minutosTramoActual >= 50 && minutosTramoActual <= 60)
                {
                    // Tramo entre 50 y 60 minutos
                    importe += precio_minuto * 50;
                    
                    if (tipoDescuento.Equals("1ª Hora Gratis") && i == 0) 
                    {
                        importe -= precio_minuto * 50;
                        this.descuento += precio_minuto * 50;
                    }
                    
                } 
                else if (minutosTramoActual > 30 && minutosTramoActual < 50)
                {
                    // Primera HORA con más de 30 minutos pero menos de 50  O  Cualquier HORA con menos de 50 minutos
                    importe += precio_minuto * minutosTramoActual;
                    
                    if (tipoDescuento.Equals("1ª Hora Gratis") && i == 0)
                    {
                        importe -= precio_minuto * minutosTramoActual;
                        this.descuento += precio_minuto * minutosTramoActual;
                    }
                }
            }

            if (tipoDescuento.Equals("1ª 1/2 Hora Gratis"))
            {
                importe -= precio_primera_media_hora;
                this.descuento += precio_primera_media_hora;
            }


            // Aplicar el descuento si corresponde
            if (descuento != 0)
            {
                decimal descuentoPorcentual = Convert.ToDecimal(descuento) / 100;
                this.descuento = importe * descuentoPorcentual;
                decimal importeConDescuento = importe - (importe * descuentoPorcentual);
                importe = importeConDescuento;
            }

            return importe * numTickets;
        }

    }
}
