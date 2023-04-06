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
    public partial class FormConsultasOut : Form
    {
        private bool cambios = false;

        public FormConsultasOut()
        {
            InitializeComponent();
        }

        private void ticketOutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketOutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlAforoDataSet);
            cambios = false;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet.TicketOut' Puede moverla o quitarla según sea necesario.
            this.ticketOutTableAdapter.Fill(this.controlAforoDataSet.TicketOut);
            cambios = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el registro? No se podrá recuperar este registro...", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {

                string respuesta = Microsoft.VisualBasic.Interaction.InputBox("Escriba la palabra 'CONFIRMAR':", "Confirmación", "");

                if (string.Equals(respuesta, "confirmar", StringComparison.OrdinalIgnoreCase)) {
                    // Obtener el valor de la columna "ID" de la fila seleccionada
                    int id = (int)ticketOutDataGridView.CurrentRow.Cells[0].Value;
                    ConectionDB conexion = new ConectionDB();
                    conexion.BorrarRegistroOut(id);
                    ticketOutDataGridView.Rows.Remove(ticketOutDataGridView.CurrentRow);
                    ticketOutTableAdapter.Fill(this.controlAforoDataSet.TicketOut);


                    MessageBox.Show("El registro se ha borrado.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cambios = false;
                } else
                {
                    MessageBox.Show("El registro NO se ha borrado.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ticketOutDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambios = true;
        }

        private void FormConsultasOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los cambios antes de cerrar?", "Confirmar cierre", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ticketOutBindingNavigatorSaveItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
