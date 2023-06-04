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
    public partial class FormAjustes : Form
    {
        Ajustes ajustes;
        int aforoMaximo = 0;
        public FormAjustes()
        {
            InitializeComponent();
        }

        private void FormAjustes_Load(object sender, EventArgs e)
        {
            CargarAjustes();
            Guardar.Enabled = false;
            GuardarCerrar.Enabled = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarAjustes();
            Guardar.Enabled = false;
            GuardarCerrar.Enabled = false;
        }

        private void GuardarCerrar_Click(object sender, EventArgs e)
        {
            GuardarAjustes();
            Guardar.Enabled = false;
            GuardarCerrar.Enabled = false;
            this.Close();
        }

        private void GuardarAjustes()
        {
            ConectionDB conexion = new ConectionDB();
            var aforoActual = conexion.calcularAforo();

            if((aforoMaximo - aforoActual) > Int32.Parse(textBoxAforo.Text))
            {
                labelResultado.Text = "Numero de personas dentro mayor que aforo... Aumente el valor";
                labelResultado.ForeColor = Color.Red;
                labelResultado.Visible = true;
                CargarAjustes();
                return;
            }

            Ajustes nuevosAjustes = new Ajustes(textBoxPrecioMinuto.Text, textBoxPrecioMediaHora.Text, 0, Int32.Parse(textBoxAforo.Text), textBoxDinero.Text);
            if (conexion.GuardarAjustes(nuevosAjustes))
            {
                labelResultado.Text = "Se han guardado correctamente los cambios";
                labelResultado.ForeColor = Color.Green;
                labelResultado.Visible = true;
                CargarAjustes();
            }
            else
            {
                labelResultado.Text = "Error al guardar los cambios";
                labelResultado.ForeColor = Color.Red;
                labelResultado.Visible = true;
            }
            FormControlAforo.actualizarAforo();
        }

        private void CargarAjustes()
        {
            ConectionDB conexion = new ConectionDB();
            ajustes = conexion.CargarAjustes();
            textBoxPrecioMediaHora.Text = ajustes.precio_primera_media_hora;
            textBoxPrecioMinuto.Text = ajustes.precio_minuto;
            textBoxAforo.Text = ajustes.aforo.ToString();
            textBoxDinero.Text = ajustes.dinero_introducido;
            aforoMaximo = ajustes.aforo;
        }

        private void activarBoton()
        {
            GuardarCerrar.Enabled = true;
            Guardar.Enabled = true;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un carácter ',' en el campo
            if (e.KeyChar == ',' && ((sender as TextBox).Text.Contains(',') || (sender as TextBox).Text.Contains('.'))  || (e.KeyChar == '.' && (  (sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(','))))
            {
                e.Handled = true;
            }
        }
    }
}
