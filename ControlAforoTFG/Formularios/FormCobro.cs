using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;
using ControlAforoTFG.ModelosDAO;
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
            if (numPersonas.Value <= 0)
            {
                DialogResult result = MessageBox.Show("No has introducido un numero de personas válido",
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

            string codigo = NuevoTicket.GenerarCodigoUnico(Convert.ToDateTime(textBoxFechaEntrada.Text));
            ConectionDB conexion = new ConectionDB();
            TicketOut ticketOut = conexion.ExisteTicketIn(codigo);
            ticketOut.NumPersonasOut = Convert.ToInt32(numPersonas.Value);

            if (ticketOut == null)
            {
                DialogResult result = MessageBox.Show("No se ha encontrado el ticket",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }
            if (!conexion.checkSalida(ticketOut))
            {
                DialogResult result = MessageBox.Show("No puede salir más gente de la que ha entrado con este ticket",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }

            //ticketOut.MetodoPago = comboBoxTipoPago.SelectedItem.ToString();
            if(radioEfectivo.Checked)
            {
                ticketOut.MetodoPago = radioEfectivo.Text;
            } else
            {
                ticketOut.MetodoPago = radioTarjeta.Text;
            }
            ticketOut.Importe = ticketOut.calcularImporte(conexion.CargarAjustes());

            TicketDAO ticketDAO = new TicketDAO();
            ticketDAO.guardarTicketOut(ticketOut);
            ControlAforo.actualizarAforo();
            DialogResult messageBox = MessageBox.Show("Importe a Pagar: " + ticketOut.Importe.ToString("0.00") + " €" +
                                                      "\nImporte por persona: " + (ticketOut.Importe / ticketOut.NumPersonasOut).ToString("0.00") + " €",
                                                      "Importe total",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
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
            dateTimeFecha.Value = Convert.ToDateTime(textBoxFechaEntrada.Text);
        }
    }
}
