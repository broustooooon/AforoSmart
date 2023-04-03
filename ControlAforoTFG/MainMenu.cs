using ControlAforoTFG.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAforoTFG
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /*Generar Nuevo Ticket*/
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoTicket soyHijo = new NuevoTicket();
            soyHijo.MdiParent = this;
            soyHijo.Text = "Documento " + this.MdiChildren.Length.ToString();
            //soyHijo.Dock= DockStyle.Fill;
            soyHijo.Show();
        }

        /*Salir de la Aplicacion*/
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
