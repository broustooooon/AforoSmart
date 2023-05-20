using ControlAforoTFG.Entidades;
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
    internal partial class FormRecibo : Form
    {
        public TicketOut ticketOut { get; set; }
        public FormRecibo()
        {
            InitializeComponent();
        }

    }
}
