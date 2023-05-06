using ControlAforoTFG.Formularios;
using ControlAforoTFG.Formularios.Consultas;
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
        public static List<Form> formulariosAbiertos = new List<Form>();
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

        /*Ventana de Consultas de Entrada*/
        private void registrosDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearConsultasIn();
        }

        /*Ventana de Consultas de Salida*/
        private void registrosDeSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearConsultasOut();
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
            // Verificar si ya existe un formulario de tipo ControlAforo
            if (formulariosAbiertos.Any(f => f.GetType() == typeof(ControlAforo)))
            {
                return;
            }

            // Si no existe, crear uno nuevo y agregarlo a la lista
            ControlAforo controlAforo = new ControlAforo();
            controlAforo.Text = "Aforo Disponible Actual";
            controlAforo.Show();
            formulariosAbiertos.Add(controlAforo);
        }

        /*Abrir Formulario de control de Aforo*/
        private void instanciarFormAforo()
        {
            ControlAforo controlAforo = new ControlAforo();
            controlAforo.Text = "Aforo Disponible Actual";
            controlAforo.Close();
        }

        private void FormAforo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Remover el formulario cerrado de la lista
            formulariosAbiertos.Remove((Form)sender);
        }

        /*Abrir Formulario de Cobro*/
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

        /*Abrir formulario de ticket*/
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

        private void crearConsultasIn()
        {
            if (this.MdiChildren.Length == 0)
            {
                FormConsultasIn nuevaConsulta = new FormConsultasIn();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Consultar Registros de Entrada";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                FormConsultasIn nuevaConsulta = new FormConsultasIn();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Consultar Registros de Entrada";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
        }

        private void crearConsultasOut()
        {
            if (this.MdiChildren.Length == 0)
            {
                FormConsultasOut nuevaConsulta = new FormConsultasOut();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Consultar Registros de Salida";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                FormConsultasOut nuevaConsulta = new FormConsultasOut();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Consultar Registros de Salida";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FormInforme nuevaConsulta = new FormInforme();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Informe";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                FormInforme nuevaConsulta = new FormInforme();
                nuevaConsulta.MdiParent = this;
                nuevaConsulta.Text = "Informe";
                nuevaConsulta.Dock = DockStyle.Fill;
                nuevaConsulta.Show();
            }
        }

        /*Boton Abrir Menu Caja*/
        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                MenuCaja nuevaMenuCaja = new MenuCaja();
                nuevaMenuCaja.MdiParent = this;
                nuevaMenuCaja.Text = "Menu Caja";
                nuevaMenuCaja.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                MenuCaja nuevaMenuCaja = new MenuCaja();
                nuevaMenuCaja.MdiParent = this;
                nuevaMenuCaja.Text = "Menu Caja";
                nuevaMenuCaja.Show();
            }
        }

        /*Abrir Formulario de Registro de Caja*/
        private void registroDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                RegistroCaja nuevaRegistroCaja = new RegistroCaja();
                nuevaRegistroCaja.MdiParent = this;
                nuevaRegistroCaja.Text = "Registro Caja";
                nuevaRegistroCaja.Dock = DockStyle.Fill;
                nuevaRegistroCaja.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                RegistroCaja nuevaRegistroCaja = new RegistroCaja();
                nuevaRegistroCaja.MdiParent = this;
                nuevaRegistroCaja.Text = "Registro de Caja";
                nuevaRegistroCaja.Dock = DockStyle.Fill;
                nuevaRegistroCaja.Show();
            }
        }

        /*Abrir Formulario de Incidencias*/
        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Incidencias nuevaIncidencias = new Incidencias();
                nuevaIncidencias.MdiParent = this;
                nuevaIncidencias.Text = "Incidencias";
                nuevaIncidencias.Dock = DockStyle.Fill;
                nuevaIncidencias.Show();
            }
            else
            {
                this.ActiveMdiChild.Close();
                Incidencias nuevaIncidencias = new Incidencias();
                nuevaIncidencias.MdiParent = this;
                nuevaIncidencias.Text = "Incidencias";
                nuevaIncidencias.Dock = DockStyle.Fill;
                nuevaIncidencias.Show();
            }
        }
    }
}
