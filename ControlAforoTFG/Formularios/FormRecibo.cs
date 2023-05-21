﻿using ControlAforoTFG.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAforoTFG.Formularios
{
    internal partial class FormRecibo : Form
    {
        private decimal IVA = 1.21m;
        //private decimal descuento = 0m;
        public FormRecibo(TicketOut ticketOut)
        {
            InitializeComponent();
            labelNumTicket.Text = ticketOut.codigo;
            labelFecha.Text = ticketOut.fecha_salida.ToShortDateString();
            labelHoraEntrada.Text = ticketOut.fecha_entrada.ToShortTimeString();
            labelHoraSalida.Text = ticketOut.fecha_salida.ToShortTimeString();
            TimeSpan diferencia = ticketOut.fecha_salida - ticketOut.fecha_entrada; // Calcula la diferencia de tiempo
            double minutosTranscurridos = Math.Round(diferencia.TotalMinutes); // Obtiene los minutos transcurridos
            labelMinutos.Text = minutosTranscurridos.ToString() + " min";
            labelNumPersonas.Text = ticketOut.num_personas_out.ToString();

            if(ticketOut.tipo_descuento.Equals("Sin Descuento"))
            {
                labelDescuento.Visible = false;
                labelDineroDescuento.Visible = false;
            } else
            {
                labelDescuento.Text = "Dto:\n" + ticketOut.tipo_descuento;
                labelDineroDescuento.Text = "-" + Math.Round(ticketOut.descuento * ticketOut.num_personas_out, 2).ToString() + " €";
            }
            
            labelPrecio.Text = (Math.Round((ticketOut.importe + ticketOut.descuento * ticketOut.num_personas_out) / ticketOut.num_personas_out, 2)).ToString() + " €";
            labelPrecioTotal.Text = Math.Round(ticketOut.importe + (ticketOut.descuento * ticketOut.num_personas_out), 2).ToString() + " €";
            labelIVA.Text = IVA.ToString();
            labelPrecioSinIVA.Text = Math.Round(ticketOut.importe / IVA, 3).ToString() + " €";
            labelValorIVA.Text = (ticketOut.importe - Math.Round(ticketOut.importe / IVA, 3)).ToString() + " €";
            labelValorTotal.Text = Math.Round(ticketOut.importe,2).ToString() + " €";
        }

    }
}
