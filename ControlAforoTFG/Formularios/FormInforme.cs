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
    public partial class FormInforme : Form
    {
        string consulta = "";
        public FormInforme()
        {
            InitializeComponent();
        }

        private void ticketOutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketOutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlAforoDataSet);

        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet.TicketOut' Puede moverla o quitarla según sea necesario.
            this.ticketOutTableAdapter.Fill(this.controlAforoDataSet.TicketOut);

        }

        /*Boton Buscar*/
        private void butBuscar_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM TicketOut WHERE fecha_salida BETWEEN '" + dateTimeInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dateTimeFin.Value.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY fecha_salida";
            consulta += "";

            ConectionDB conexion = new ConectionDB();
            List<TicketOut> listaTickets = conexion.DevolverInforme(consulta);
            ticketOutDataGridView.AutoGenerateColumns = true;
            ticketOutDataGridView.DataSource = listaTickets;
            ticketOutDataGridView.DataSource = listaTickets;
        }


        /*Boton Generar Informe*/
        private void butGenerarInforme_Click(object sender, EventArgs e)
        {

        }
    }
}
