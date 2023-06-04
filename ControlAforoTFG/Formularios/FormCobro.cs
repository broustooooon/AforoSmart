using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;
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
    public partial class FormCobro : Form
    {
        public FormCobro()
        {
            InitializeComponent();
            comboDescuento.SelectedIndex = 0;
        }

        /*Boton Cobrar*/
        private void butCobrar_Click(object sender, EventArgs e)
        {
            if (textBoxFechaEntrada.Text.Trim().Equals(""))
            {
                DialogResult result = MessageBox.Show("No has introducido la fecha",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }
            if (numPersonas.Value <= 0 || numericPorcentajeDescuento.Value < 0)
            {
                DialogResult result = MessageBox.Show("No se admiten números negativos.",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }
            if (!radioEfectivo.Checked && !radioTarjeta.Checked)
            {
                DialogResult result = MessageBox.Show("No has introducido un metodo de pago",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }

            string codigo = FormNuevoTicket.GenerarCodigoUnico(Convert.ToDateTime(textBoxFechaEntrada.Text));
            ConectionDB conexion = new ConectionDB();
            TicketOut ticketOut = conexion.ExisteTicketIn(codigo);

            if (ticketOut == null)
            {
                DialogResult result = MessageBox.Show("No se ha encontrado el ticket",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }

            ticketOut.codigo = codigo;
            ticketOut.num_personas_out = Convert.ToInt32(numPersonas.Value);
            
            if (!conexion.checkSalida(ticketOut))
            {
                DialogResult result = MessageBox.Show("No puede salir más gente de la que ha entrado con este ticket",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }

            if(radioEfectivo.Checked)
            {
                ticketOut.metodo_pago = radioEfectivo.Text;
            } else
            {
                ticketOut.metodo_pago = radioTarjeta.Text;
            }

            ticketOut.importe = ticketOut.calcularImporte(conexion.CargarAjustes(), comboDescuento.SelectedItem.ToString(), Int32.Parse(numericPorcentajeDescuento.Value.ToString()), Int32.Parse(numPersonas.Value.ToString()));            
            ticketOut.tipo_descuento = comboDescuento.SelectedItem.ToString();

            conexion.GuardarTicketOut(ticketOut);
            FormControlAforo.actualizarAforo();
            DialogResult messageBox = MessageBox.Show("Importe a Pagar: " + ticketOut.importe.ToString("0.00")  + " €" +
                                                      "\nImporte por persona: " + (ticketOut.importe / ticketOut.num_personas_out).ToString("0.00") + " €",
                                                      "Importe total",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);

            FormRecibo recibo = new FormRecibo(ticketOut);
            recibo.Text = "Nuevo Recibo";
            recibo.Show();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {
            textBoxFechaEntrada.Text = dateTimeFecha.Value.ToString();
        }

        private void textBoxFechaEntrada_TextChanged(object sender, EventArgs e)
        {
            try {
                dateTimeFecha.Value = Convert.ToDateTime(textBoxFechaEntrada.Text);
            } catch (Exception)
            {
                
            }
        }

        private void comboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDescuento.SelectedIndex == 3)
            {
                numericPorcentajeDescuento.Visible = true;
            }
            else
            {
                numericPorcentajeDescuento.Visible = false;
            }
        }
    }
}
