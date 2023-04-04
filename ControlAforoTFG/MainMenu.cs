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
        int ancho;
        int alto;
        private Point posicionInicial = new Point(23,32);
        public MainMenu()
        {
            InitializeComponent();
            ancho = this.Location.X;
            alto = this.Location.Y;
            posicionInicial = new Point(this.Location.X, this.Location.Y);
        }

        /*Generar Nuevo Ticket*/
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoTicket nuevoTicket = new NuevoTicket();
            nuevoTicket.Location = posicionInicial;
            //nuevoTicket.MdiParent = this;
            nuevoTicket.Text = "Nuevo Ticket";
            nuevoTicket.ShowDialog();
            nuevoTicket.Focus();
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
    }
}
