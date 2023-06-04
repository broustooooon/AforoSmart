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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet.Incidencias' Puede moverla o quitarla según sea necesario.
            this.incidenciasTableAdapter.Fill(this.controlAforoDataSet.Incidencias);

        }
    }
}
