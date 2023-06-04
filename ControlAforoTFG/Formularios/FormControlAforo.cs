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
    public partial class FormControlAforo : Form
    {
        private static Label label;
        public FormControlAforo()
        {
            InitializeComponent();
            label = label1;
        }

        private void ControlAforo_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2,
                               (this.ClientSize.Height - label1.Height) / 2);
        }

        private void ControlAforo_Load(object sender, EventArgs e)
        {
            actualizarAforo();
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2,
                           (this.ClientSize.Height - label1.Height) / 2);
        }

        public static void actualizarAforo()
        {
            ConectionDB conection = new ConectionDB();
            label.Text = "Aforo Disponible: "+conection.calcularAforo().ToString();
        }

        /*Impide que se abran mas formularios*/
        private void ControlAforo_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.formulariosAbiertos.Remove((Form)sender);
        }
    }
}
