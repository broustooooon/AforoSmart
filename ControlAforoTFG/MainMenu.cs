using ControlAforoTFG.Formularios;
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
using static QRCoder.PayloadGenerator;

namespace ControlAforoTFG
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            instanciarFormAforo();
        }

        /*Generar Nuevo Ticket*/
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crearNuevoTicket();
        }

        /*Salir de la Aplicacion*/
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Crear Base de Datos*/
        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //preguntar si se desea crear la base de datos: Yes, No
            DialogResult result = MessageBox.Show("¿Desea crear la base de datos?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                ConectionDB conexion = new ConectionDB();
                conexion.ScriptBaseDeDatos();
            }
        }

        /*Desplegar pestaña de ajustes*/
        private void precioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjustes ajustes = new FormAjustes();
            ajustes.Text = "Ventana de Ajustes";
            ajustes.ShowDialog();
            ajustes.Focus();
        }

        private void cobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearFormCobro();
        }

        private void butNuevoTicket_Click(object sender, EventArgs e)
        {
            crearNuevoTicket();
        }

        private void butCobroTicket_Click(object sender, EventArgs e)
        {
            crearFormCobro();
        }

        private void aforoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearFormAforo();
        }

        private void crearFormAforo()
        {
            ControlAforo controlAforo = new ControlAforo();
            controlAforo.Text = "Aforo Disponible Actual";
            controlAforo.Show();
        }

        private void instanciarFormAforo()
        {
            ControlAforo controlAforo = new ControlAforo();
            controlAforo.Text = "Aforo Disponible Actual";
            controlAforo.Close();
        }

        private void crearFormCobro()
        {
            if (this.MdiChildren.Length == 0)
            {
                FormCobro nuevoCobro = new FormCobro();
                nuevoCobro.MdiParent = this;
                nuevoCobro.Text = "Nuevo Cobro";
                nuevoCobro.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                FormCobro nuevoCobro = new FormCobro();
                nuevoCobro.MdiParent = this;
                nuevoCobro.Text = "Nuevo Cobro";
                nuevoCobro.Show();
            }
        }

        private void crearNuevoTicket()
        {
            if (this.MdiChildren.Length == 0)
            {
                NuevoTicket nuevoTicket = new NuevoTicket();
                nuevoTicket.MdiParent = this;
                nuevoTicket.Text = "Nuevo Ticket";
                nuevoTicket.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                NuevoTicket nuevoTicket = new NuevoTicket();
                nuevoTicket.MdiParent = this;
                nuevoTicket.Text = "Nuevo Ticket";
                nuevoTicket.Show();
            }
        }
    }
}
