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
        }

        private void GuardarCerrar_Click(object sender, EventArgs e)
        {
            GuardarAjustes();
            this.Close();
        }

        private void GuardarAjustes()
        {
            Ajustes nuevosAjustes = new Ajustes(textBoxPrecioMinuto.Text, textBoxPrecioMediaHora.Text, Int32.Parse(textBoxDescuento.Text)); ;
            if(ajustesDAO.guardarAjustes(nuevosAjustes))
            {
                labelResultado.Text = "Se han guardado correctamente los cambios";
                labelResultado.ForeColor = Color.Green;
                labelResultado.Visible = true;
                CargarAjustes();
            } else
            {
                labelResultado.Text = "Error al guardar los cambios";
                labelResultado.ForeColor = Color.Red;
                labelResultado.Visible = true;
            }
        }

        private void CargarAjustes()
        {
            ajustes = ajustesDAO.cargarAjustes();
            textBoxPrecioMediaHora.Text = ajustes.precio_primera_media_hora;
            textBoxPrecioMinuto.Text = ajustes.precio_minuto;
            textBoxDescuento.Text = ajustes.descuento.ToString();
        }

        private void activarBoton()
        {
            GuardarCerrar.Enabled = true;
            Guardar.Enabled = true;
        }

        private void textBoxPrecioMinuto_TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void textBoxPrecioMediaHora_TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            activarBoton();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
