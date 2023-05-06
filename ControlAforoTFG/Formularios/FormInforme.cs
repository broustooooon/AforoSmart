using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //this.ticketOutTableAdapter.Fill(this.controlAforoDataSet.TicketOut);
            DateTime fechaNow = DateTime.Now;
            dateTimeFin.Value = fechaNow;
            dateTimeInicio.Value = fechaNow;

            consulta = "SELECT * FROM TicketOut order by fecha_salida";
            ConectionDB conexion = new ConectionDB();
            List<TicketOut> listaTickets = conexion.DevolverInforme(consulta);
            ticketOutDataGridView.AutoGenerateColumns = true;
            ticketOutDataGridView.DataSource = listaTickets;
        }

        /*Boton Buscar*/
        private void butBuscar_Click(object sender, EventArgs e)
        {
            if (dateTimeFin.Value < dateTimeInicio.Value)
            {
                DialogResult result = MessageBox.Show("La fecha de fin es anterior a la de inicio...",
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                return;
            }

            consulta = "SELECT * FROM TicketOut WHERE fecha_salida BETWEEN '" + dateTimeInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dateTimeFin.Value.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY fecha_salida";

            ConectionDB conexion = new ConectionDB();
            List<TicketOut> listaTickets = conexion.DevolverInforme(consulta);
            ticketOutDataGridView.AutoGenerateColumns = true;
            ticketOutDataGridView.DataSource = listaTickets;
            //ticketOutDataGridView.DataSource = listaTickets;
        }

        /*Boton Generar Informe*/
        private void butGenerarInforme_Click(object sender, EventArgs e)
        {
            if (ticketOutDataGridView.Rows.Count > 0)
            {
                var meses = ticketOutDataGridView.Rows.Cast<DataGridViewRow>()
                            .Where(r => r.Cells["dataGridViewTextBoxColumn5"].Value != null)
                            .GroupBy(r => new DateTime(((DateTime)r.Cells["dataGridViewTextBoxColumn5"].Value).Year,
                            ((DateTime)r.Cells["dataGridViewTextBoxColumn5"].Value).Month, 1));

                // Mostrar el diálogo de selección de archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar informe como...";
                saveFileDialog.FileName = "Informe";
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                        PdfWriter.GetInstance(document, fileStream);
                        document.Open();

                        var importesPorMetodoPagoMes = new Dictionary<string, List<decimal>>();

                        foreach (var mes in meses)
                        {
                            var fecha = mes.Key.ToString("MMMM yyyy"); // Cambia el formato de la fecha a "mes año"
                            var dias = mes.GroupBy(r => ((DateTime)r.Cells["dataGridViewTextBoxColumn5"].Value).Date); // Agrupa los registros del mes por día

                            var fechaParrafo = new Paragraph(("Mes: " + fecha).ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                            fechaParrafo.Alignment = Element.ALIGN_LEFT;
                            document.Add(fechaParrafo);

                            decimal importeMes = 0m;

                            var importesPorMetodoPagoDia = new Dictionary<string, List<decimal>>(); // Creamos un diccionario para almacenar los importes por método de pago

                            foreach (var dia in dias)
                            {
                                var fechaDia = ("Dia " + ((DateTime)dia.Key).ToString("dd/MM/yyyy") + ":");
                                var metodosPago = dia.GroupBy(r => r.Cells["dataGridViewTextBoxColumn7"].Value.ToString());

                                var fechaDiaParrafo = new Paragraph(fechaDia);
                                fechaDiaParrafo.Alignment = Element.ALIGN_LEFT;
                                document.Add(fechaDiaParrafo);

                                decimal importeDia = 0m;

                                foreach (var metodo in metodosPago)
                                {
                                    var importeMetodoPago = 0m; // Inicializamos la variable para guardar el importe total de cada método de pago
                                    document.Add(new Paragraph(metodo.Key));

                                    // Crear una nueva tabla para cada método de pago
                                    PdfPTable pTable = new PdfPTable(ticketOutDataGridView.Columns.Count);
                                    pTable.DefaultCell.Padding = 2;
                                    pTable.WidthPercentage = 100;
                                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;


                                    foreach (DataGridViewColumn col in ticketOutDataGridView.Columns)
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                        pTable.AddCell(pCell);
                                    }

                                    foreach (DataGridViewRow viewRow in metodo)
                                    {
                                        foreach (DataGridViewCell dcell in viewRow.Cells)
                                        {
                                            object value = dcell.Value;
                                            string strValue = value != null ? value.ToString() : string.Empty;
                                            pTable.AddCell(strValue);

                                            if (dcell.OwningColumn.Name == "dataGridViewTextBoxColumn6") // Si es la columna del importe
                                            {
                                                importeMetodoPago += Convert.ToDecimal(value); // Sumamos el importe al total del método de pago
                                            }
                                        }
                                    }

                                    // Agregamos el importe total del método de pago en el diccionario
                                    if (!importesPorMetodoPagoDia.ContainsKey(metodo.Key))
                                    {
                                        importesPorMetodoPagoDia[metodo.Key] = new List<decimal>();
                                    }
                                    importesPorMetodoPagoDia[metodo.Key].Add(importeMetodoPago);

                                    if (!importesPorMetodoPagoMes.ContainsKey(metodo.Key))
                                    {
                                        importesPorMetodoPagoMes[metodo.Key] = new List<decimal>();
                                    }
                                    importesPorMetodoPagoMes[metodo.Key].Add(importeMetodoPago);

                                    // Agregamos la tabla a una nueva página del documento PDF
                                    document.Add(pTable);

                                    // Mostrar el importe total por método de pago
                                    var importeMetodoParrafo = new Paragraph($"Subtotal recaudado por {metodo.Key} en {fechaDia} {importeMetodoPago} €");
                                    importeMetodoParrafo.Alignment = Element.ALIGN_RIGHT;
                                    importeMetodoParrafo.SpacingBefore = 10f;
                                    importeMetodoParrafo.Font.Color = BaseColor.GREEN;
                                    document.Add(importeMetodoParrafo);

                                    importeDia += importeMetodoPago;
                                    importeMes += importeMetodoPago;
                                }

                                // Mostramos el importe total recaudado por cada día
                                var importeDiaParrafo = new Paragraph($"Total recaudado en {fechaDia} {importeDia} €");
                                importeDiaParrafo.Alignment = Element.ALIGN_RIGHT;
                                importeDiaParrafo.SpacingBefore = 10f;
                                document.Add(importeDiaParrafo);

                            }

                            // Mostramos el total recaudado por método de pago por cada mes
                            foreach (var kvp in importesPorMetodoPagoDia)
                            {
                                var importeMetodoMesParrafo = new Paragraph($"Total recaudado por {kvp.Key} en {fecha}: {kvp.Value.Sum()} €");
                                importeMetodoMesParrafo.Alignment = Element.ALIGN_LEFT;
                                importeMetodoMesParrafo.SpacingBefore = 10f;
                                document.Add(importeMetodoMesParrafo);
                            }


                            // Mostramos el importe total del mes
                            var importeMesParrafo = new Paragraph($"Total recaudado en {fecha.ToUpper()}: {importeMes} €");
                            importeMesParrafo.Alignment = Element.ALIGN_LEFT;
                            importeMesParrafo.SpacingBefore = 10f;
                            document.Add(importeMesParrafo);

                            document.NewPage();
                        }

                        var tituloResultadoInforme = new Paragraph("RESULTADO DEL INFORME:");
                        tituloResultadoInforme.Alignment = Element.ALIGN_LEFT;
                        document.Add(tituloResultadoInforme);

                        decimal totalRecaudado = 0;
                        // Mostramos el total recaudado por método de pago en total
                        foreach (var kvp in importesPorMetodoPagoMes)
                        {
                            var importeMetodoParrafo = new Paragraph($"Total recaudado por {kvp.Key}: {kvp.Value.Sum()} €");
                            importeMetodoParrafo.Alignment = Element.ALIGN_LEFT;
                            importeMetodoParrafo.SpacingBefore = 10f;
                            importeMetodoParrafo.Font.Color = BaseColor.BLUE;
                            document.Add(importeMetodoParrafo);

                            totalRecaudado += kvp.Value.Sum();
                        }

                        //Mostrar cuantia total
                        var totalParrafo = new Paragraph($"Total recaudado: {totalRecaudado} €");
                        totalParrafo.Alignment = Element.ALIGN_LEFT;
                        totalParrafo.SpacingBefore = 10f;
                        totalParrafo.Font.Color = BaseColor.BLUE;
                        document.Add(totalParrafo);


                        document.Close();
                        fileStream.Close();
                    }
                    MessageBox.Show("Informe generado Correctamente", "Info");
                }
                else
                {
                    MessageBox.Show("Error al cargar la Informacion", "Info");
                }
            }
        }
    }
}
