using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAforoTFG.Formularios.Consultas
{
    public partial class FormRegistroCaja : Form
    {
        public FormRegistroCaja()
        {
            InitializeComponent();
        }

        private void RegistroCaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet.RegistroCaja' Puede moverla o quitarla según sea necesario.
            this.registroCajaTableAdapter.Fill(this.controlAforoDataSet.RegistroCaja);

        }
    }
}
