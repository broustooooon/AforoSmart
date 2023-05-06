using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;
using ControlAforoTFG.ModelosDAO;
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
        AjustesDAO ajustesDAO = new AjustesDAO();
        Ajustes ajustes;
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
            Ajustes nuevosAjustes = new Ajustes(textBoxPrecioMinuto.Text, textBoxPrecioMediaHora.Text, Int32.Parse(textBoxDescuento.Text), Int32.Parse(textBoxAforo.Text), textBoxDinero.Text);
            if (ajustesDAO.guardarAjustes(nuevosAjustes))
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
            ControlAforo.actualizarAforo();
        }

        private void CargarAjustes()
        {
            ajustes = ajustesDAO.cargarAjustes();
            textBoxPrecioMediaHora.Text = ajustes.precio_primera_media_hora;
            textBoxPrecioMinuto.Text = ajustes.precio_minuto;
            textBoxDescuento.Text = ajustes.descuento.ToString();
            textBoxAforo.Text = ajustes.aforo.ToString();
            textBoxDinero.Text = ajustes.dinero_introducido;
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
