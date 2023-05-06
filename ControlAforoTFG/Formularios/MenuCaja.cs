using ControlAforoTFG.ControlAforoDataSetTableAdapters;
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
    public partial class MenuCaja : Form
    {
        public MenuCaja()
        {
            InitializeComponent();
        }

        /*Boton Abrir Caja*/
        private void butAbrirCaja_Click(object sender, EventArgs e)
        {
            ConectionDB conexion = new ConectionDB();

            bool existeCajaAbierta = conexion.EstadoCaja();

            if (existeCajaAbierta)
            {
                DialogResult result = MessageBox.Show("Hay una caja que no se cerró, ¿desea hacerlo?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    conexion.cerrarTicket();
                    MessageBox.Show("Se ha cerrado la Caja.", this.Text);
                    conexion.insertarIncidencia(new Entidades.Incidencia(DateTime.Now, "Apertura sin cierre previo"));
                } else
                {
                    return;
                }
            }

            string respuesta = Microsoft.VisualBasic.Interaction.InputBox("Escribe cuanto dinero vas a introducir en la caja:", "Dinero:", "");
            if(EsNumero(respuesta))
            {
                conexion.CambiarDineroCaja(respuesta);
                conexion.AbrirCaja();
                butContarDinero.Enabled = true;
                butCerrarCaja.Enabled = true;
                conexion.insertarRegistroCaja(new Entidades.RegistroCaja(DateTime.Now, "Apertura", conexion.GetDineroCaja(), 
                    conexion.GetEfectivoAbierto()/100, conexion.GetOtrosAbierto()/100));
            } else
            {
                DialogResult result = MessageBox.Show("NO se ha abierto la caja",
                                                      "Aviso",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
            }
        }

        /*Boton Cerrar Caja*/
        private void butCerrarCaja_Click(object sender, EventArgs e)
        {
            ConectionDB conexion = new ConectionDB();

            bool existeCajaAbierta = conexion.EstadoCaja();

            if (existeCajaAbierta)
            {
                string[] dinero = conexion.CalcularCierreCaja();

                MessageBox.Show("Dinero recaudado hasta el momento.\nEfectivo Recaudado: " + dinero[0].ToString() + " €" + "\nOtros: " + dinero[1].ToString() + " €" +
                    "\nDinero al Abrir Caja: " + dinero[2] + " €" + "\nTotal Caja: " + ((Double.Parse(dinero[0]) + Double.Parse(dinero[2])) / 100).ToString("0.00") + " €"+ 
                    "\n\nTotal Cierre: " + ((Double.Parse(dinero[0]) + Double.Parse(dinero[1]) + Double.Parse(dinero[2])) / 100).ToString("0.00") + " €", this.Text);

                conexion.cerrarTicket();
                butCerrarCaja.Enabled = false;
                butContarDinero.Enabled = false;
                conexion.CerrarCaja();
                conexion.insertarRegistroCaja(new Entidades.RegistroCaja(DateTime.Now, "Cierre", Decimal.Parse(dinero[2])/100, Decimal.Parse(dinero[0]) / 100, Decimal.Parse(dinero[1]) / 100));
            } else
            {
                DialogResult result = MessageBox.Show("No se ha abierto la caja",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
            }
        }

        /*Boton Contar Dinero*/
        private void butContarDinero_Click(object sender, EventArgs e)
        {
            ConectionDB conexion = new ConectionDB();

            bool existeCajaAbierta = conexion.EstadoCaja();

            if (existeCajaAbierta)
            {
                string[] dinero = conexion.CalcularCierreCaja();
                MessageBox.Show("Dinero recaudado hasta el momento.\nEfectivo Recaudado: " + dinero[0].ToString() + " €" + "\nOtros: " + dinero[1].ToString() + " €" +
                    "\nDinero al Abrir Caja: " + dinero[2] + " €" + "\nTotal Caja: " + ((Double.Parse(dinero[0]) + Double.Parse(dinero[2])) / 100).ToString("0.00") + " €" +
                    "\n\nTotal Cierre: " + ((Double.Parse(dinero[0]) + Double.Parse(dinero[1]) + Double.Parse(dinero[2])) / 100).ToString("0.00") + " €", this.Text);
            }
            else
            {
                DialogResult result = MessageBox.Show("No se ha abierto la caja",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
            }
        }

        private void MenuCaja_Load(object sender, EventArgs e)
        {
            ConectionDB conexion = new ConectionDB();
            if (!conexion.EstadoCaja())
            {
                butCerrarCaja.Enabled = false;
                butContarDinero.Enabled = false;
            }
        }

        private bool EsNumero(string valor)
        {
            double numero;
            return Double.TryParse(valor, out numero);
        }

    }
}
