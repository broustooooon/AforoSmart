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
        private decimal IVA = 1.21m;
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
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet2.TicketOut' Puede moverla o quitarla según sea necesario.
            this.ticketOutTableAdapter1.Fill(this.controlAforoDataSet2.TicketOut);
            // TODO: esta línea de código carga datos en la tabla 'controlAforoDataSet.TicketOut' Puede moverla o quitarla según sea necesario.
            //this.ticketOutTableAdapter.Fill(this.controlAforoDataSet.TicketOut);
            DateTime fechaNow = DateTime.Now;
            dateTimeFin.Value = fechaNow;
            dateTimeInicio.Value = fechaNow;

            consulta = "SELECT * FROM TicketOut order by fecha_salida";
            ConectionDB conexion = new ConectionDB();
            List<TicketOut> listaTickets = conexion.DevolverInforme(consulta);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listaTickets;

            
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listaTickets;
            //ticketOutDataGridView.DataSource = listaTickets;
        }

        /*Boton Generar Informe*/
        private void butGenerarInforme_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var meses = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Where(r => r.Cells["dataGridViewTextBoxColumn4"].Value != null)
                            .GroupBy(r => new DateTime(((DateTime)r.Cells["dataGridViewTextBoxColumn4"].Value).Year,
                            ((DateTime)r.Cells["dataGridViewTextBoxColumn4"].Value).Month, 1));

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
                            var dias = mes.GroupBy(r => ((DateTime)r.Cells["dataGridViewTextBoxColumn4"].Value).Date); // Agrupa los registros del mes por día

                            var fechaParrafo = new Paragraph(("Mes: " + fecha).ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                            fechaParrafo.Alignment = Element.ALIGN_LEFT;
                            document.Add(fechaParrafo);

                            decimal importeMes = 0m;

                            var importesPorMetodoPagoDia = new Dictionary<string, List<decimal>>(); // Creamos un diccionario para almacenar los importes por método de pago

                            foreach (var dia in dias)
                            {
                                var fechaDia = ("Dia " + ((DateTime)dia.Key).ToString("dd/MM/yyyy") + ":");
                                var metodosPago = dia.GroupBy(r => r.Cells["dataGridViewTextBoxColumn6"].Value.ToString());

                                var fechaDiaParrafo = new Paragraph(fechaDia);
                                fechaDiaParrafo.Alignment = Element.ALIGN_LEFT;
                                document.Add(fechaDiaParrafo);

                                decimal importeDia = 0m;

                                foreach (var metodo in metodosPago)
                                {
                                    var importeMetodoPago = 0m; // Inicializamos la variable para guardar el importe total de cada método de pago
                                    var parrafoMetodoPago = new Paragraph();

                                    Chunk chunk = new Chunk(metodo.Key);
                                    chunk.SetUnderline(1, -2); // Aplica subrayado a todo el texto

                                    parrafoMetodoPago.Add(chunk);
                                    parrafoMetodoPago.SpacingBefore = 10f;
                                    parrafoMetodoPago.SpacingAfter = 10f;

                                    document.Add(parrafoMetodoPago);


                                    // Crear una nueva tabla para cada método de pago
                                    PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                    pTable.DefaultCell.Padding = 2;
                                    pTable.WidthPercentage = 100;
                                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                    Dictionary<string, string> columnaMappings = new Dictionary<string, string> {
                                        { "id", "ID" },
                                        { "codigo", "Código" },
                                        { "fecha_entrada", "Fecha de Entrada" },
                                        { "fecha_salida", "Fecha de Salida" },
                                        { "tipo_descuento", "Descuento" },
                                        { "metodo_pago", "Método de Pago" },
                                        { "estado", "Estado" },
                                        { "num_personas_out", "Número de Personas" },
                                        { "importe", "Importe" }
                                    };

                                    foreach (DataGridViewColumn col in dataGridView1.Columns )
                                    {
                                        string nombreColumna = col.HeaderText;

                                        // Verificar si hay un mapeo para el nombre de la columna
                                        if (columnaMappings.ContainsKey(nombreColumna))
                                        {
                                            nombreColumna = columnaMappings[nombreColumna]; // Obtener el nombre actualizado del diccionario
                                        }

                                        PdfPCell pCell = new PdfPCell(new Phrase(nombreColumna));
                                        pCell.BackgroundColor = BaseColor.GRAY;
                                        pTable.AddCell(pCell);
                                    }


                                    foreach (DataGridViewRow viewRow in metodo)
                                    {
                                        // Establecer el color de fondo de las celdas en LIGHT.GRAY
                                        pTable.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;

                                        foreach (DataGridViewCell dcell in viewRow.Cells)
                                        {
                                            object value = dcell.Value;
                                            string strValue = value != null ? value.ToString() : string.Empty;
                                            pTable.AddCell(strValue);

                                            if (dcell.OwningColumn.Name == "dataGridViewTextBoxColumn9") // Si es la columna del importe
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
                                    //var importeMetodoParrafo = new Paragraph($"Subtotal recaudado por {metodo.Key} en {fechaDia} {importeMetodoPago} €");
                                    var importeMetodoParrafo = new Paragraph($"{metodo.Key} {fechaDia} {importeMetodoPago} €");
                                    importeMetodoParrafo.Alignment = Element.ALIGN_RIGHT;
                                    importeMetodoParrafo.SpacingBefore = 10f;
                                    importeMetodoParrafo.Font.Color = BaseColor.GREEN;
                                    document.Add(importeMetodoParrafo);

                                    importeDia += importeMetodoPago;
                                    importeMes += importeMetodoPago;
                                }

                                // Mostramos el importe total recaudado por cada día
                                //var importeDiaParrafo = new Paragraph($"Total recaudado en {fechaDia} {importeDia} €");
                                var importeDiaParrafo = new Paragraph($"{fechaDia} {importeDia} €");
                                importeDiaParrafo.Alignment = Element.ALIGN_RIGHT;
                                importeDiaParrafo.SpacingBefore = 10f;
                                importeDiaParrafo.SpacingAfter = 10f;
                                document.Add(importeDiaParrafo);
                            }

                            document.NewPage();

                            var resumenMes = new Paragraph(("RESUMEN Mes: " + fecha).ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                            resumenMes.Alignment = Element.ALIGN_LEFT;
                            resumenMes.SpacingAfter = 10f;
                            document.Add(resumenMes);

                            // Crear tabla para mostrar los totales recaudados por método de pago por cada mes
                            PdfPTable tablaImportesPorMetodoPago = new PdfPTable(4); // 4 columnas: Método de Pago, Fecha, Total Recaudado y Total Recaudado SIN IVA
                            tablaImportesPorMetodoPago.WidthPercentage = 100; // Ancho de la tabla en porcentaje

                            // Agregar encabezados de columna a la tabla
                            PdfPCell metodoPagoHeader = new PdfPCell(new Phrase("Método de Pago"));
                            metodoPagoHeader.BackgroundColor = BaseColor.GRAY;
                            tablaImportesPorMetodoPago.AddCell(metodoPagoHeader);

                            PdfPCell fechaHeader = new PdfPCell(new Phrase("Fecha"));
                            fechaHeader.BackgroundColor = BaseColor.GRAY;
                            tablaImportesPorMetodoPago.AddCell(fechaHeader);

                            PdfPCell totalSinIVAHeader = new PdfPCell(new Phrase("Total SIN IVA"));
                            totalSinIVAHeader.BackgroundColor = BaseColor.GRAY;
                            tablaImportesPorMetodoPago.AddCell(totalSinIVAHeader);

                            PdfPCell totalHeader = new PdfPCell(new Phrase("Total"));
                            totalHeader.BackgroundColor = BaseColor.GRAY;
                            tablaImportesPorMetodoPago.AddCell(totalHeader);

                            // Agregar filas con los datos correspondientes a la tabla
                            foreach (var kvp in importesPorMetodoPagoDia)
                            {
                                PdfPCell metodoPagoCell = new PdfPCell(new Phrase(kvp.Key));
                                metodoPagoCell.BackgroundColor = BaseColor.GRAY;
                                tablaImportesPorMetodoPago.AddCell(metodoPagoCell); // Método de Pago

                                PdfPCell fechaCell = new PdfPCell(new Phrase(fecha.ToUpper()));
                                fechaCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                tablaImportesPorMetodoPago.AddCell(fechaCell); // Fecha

                                decimal totalSinIVA = Math.Round(kvp.Value.Sum() / IVA, 3);
                                PdfPCell totalSinIVACell = new PdfPCell(new Phrase($"{totalSinIVA} €"));
                                totalSinIVACell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                tablaImportesPorMetodoPago.AddCell(totalSinIVACell); // Total Recaudado SIN IVA

                                PdfPCell totalCell = new PdfPCell(new Phrase($"{kvp.Value.Sum()} €"));
                                totalCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                tablaImportesPorMetodoPago.AddCell(totalCell); // Total Recaudado
                            }

                            // Agregar la tabla al documento
                            document.Add(tablaImportesPorMetodoPago);

                            var totalMes = new Paragraph(("TOTAL Mes: " + fecha).ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                            totalMes.Alignment = Element.ALIGN_LEFT;
                            totalMes.SpacingBefore = 15f;
                            //totalMes.SpacingAfter = 10f;
                            document.Add(totalMes);

                            // Mostrar el importe total del mes
                            PdfPTable tablaImporteMes = new PdfPTable(3); // 3 columnas: Fecha, Total Recaudado y Total Recaudado SIN IVA
                            tablaImporteMes.WidthPercentage = 100; // Ancho de la tabla en porcentaje

                            // Agregar encabezados de columna a la tabla
                            tablaImporteMes.AddCell(new PdfPCell(new Phrase("Fecha")) { BackgroundColor = BaseColor.GRAY });
                            tablaImporteMes.AddCell(new PdfPCell(new Phrase("Total SIN IVA")) { BackgroundColor = BaseColor.GRAY });
                            tablaImporteMes.AddCell(new PdfPCell(new Phrase("Total")) { BackgroundColor = BaseColor.GRAY });

                            // Agregar fila con los datos correspondientes a la tabla
                            PdfPCell fechaCellTotal = new PdfPCell(new Phrase(fecha.ToUpper()));
                            fechaCellTotal.BackgroundColor = BaseColor.LIGHT_GRAY;
                            tablaImporteMes.AddCell(fechaCellTotal); // Fecha

                            decimal totalMesSinIVA = Math.Round(importeMes / IVA, 3);
                            PdfPCell totaTotallSinIVACell = new PdfPCell(new Phrase($"{totalMesSinIVA} €"));
                            totaTotallSinIVACell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            tablaImporteMes.AddCell(totaTotallSinIVACell); // Total Recaudado SIN IVA

                            PdfPCell totalTotalCell = new PdfPCell(new Phrase($"{importeMes} €"));
                            totalTotalCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            tablaImporteMes.AddCell(totalTotalCell); // Total Recaudado


                            var parrafoAux = new Paragraph("");
                            parrafoAux.SpacingBefore = 10f;
                            document.Add(parrafoAux);

                            // Agregar la tabla al documento
                            document.Add(tablaImporteMes);

                            // Agregar un salto de página
                            document.NewPage();

                        }

                        var tituloResultadoInforme = new Paragraph("RESULTADO DEL INFORME: DESDE " + meses.First().Key.ToString("MMMM yyyy").ToUpper() + " HASTA " + meses.Last().Key.ToString("MMMM yyyy").ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                        tituloResultadoInforme.Alignment = Element.ALIGN_LEFT;
                        tituloResultadoInforme.SpacingAfter = 10f;
                        document.Add(tituloResultadoInforme);

                        // Crear tabla para mostrar los totales recaudados por método de pago en total
                        PdfPTable tablaTotalesPorMetodoPago = new PdfPTable(2); // 2 columnas: Método de Pago y Total Recaudado
                        tablaTotalesPorMetodoPago.WidthPercentage = 100; // Ancho de la tabla en porcentaje

                        // Definir colores
                        BaseColor colorTitulo = BaseColor.GRAY;
                        BaseColor colorCeldas = BaseColor.LIGHT_GRAY;

                        // Agregar encabezados de columna a la tabla con color
                        PdfPCell tituloMetodoPago = new PdfPCell(new Phrase("Método de Pago"));
                        tituloMetodoPago.BackgroundColor = colorTitulo;
                        tablaTotalesPorMetodoPago.AddCell(tituloMetodoPago);

                        PdfPCell tituloTotalRecaudado = new PdfPCell(new Phrase("Total Recaudado"));
                        tituloTotalRecaudado.BackgroundColor = colorTitulo;
                        tablaTotalesPorMetodoPago.AddCell(tituloTotalRecaudado);

                        // Agregar filas con los datos correspondientes a la tabla
                        foreach (var kvp in importesPorMetodoPagoMes)
                        {
                            PdfPCell celdaMetodoPago = new PdfPCell(new Phrase(kvp.Key));
                            celdaMetodoPago.BackgroundColor = colorCeldas;
                            tablaTotalesPorMetodoPago.AddCell(celdaMetodoPago);

                            PdfPCell celdaTotalRecaudado = new PdfPCell(new Phrase($"{kvp.Value.Sum()} €"));
                            celdaTotalRecaudado.BackgroundColor = colorCeldas;
                            tablaTotalesPorMetodoPago.AddCell(celdaTotalRecaudado);
                        }

                        // Mostrar la tabla de totales por método de pago en total
                        document.Add(tablaTotalesPorMetodoPago);


                        /// Calcular los totales generales con y sin IVA
                        decimal totalRecaudado = importesPorMetodoPagoMes.Values.Sum(x => x.Sum());
                        decimal totalResumenSinIVA = Math.Round(totalRecaudado / IVA, 3);

                        // Crear tabla para mostrar los totales generales
                        PdfPTable tablaTotalesGenerales = new PdfPTable(2); // 2 columnas: Total y Total SIN IVA
                        tablaTotalesGenerales.WidthPercentage = 100; // Ancho de la tabla en porcentaje
                        tablaTotalesGenerales.SpacingBefore = 15f;

                        PdfPCell tituloTotalSinIVA = new PdfPCell(new Phrase("Total SIN IVA"));
                        tituloTotalSinIVA.BackgroundColor = colorTitulo;
                        tablaTotalesGenerales.AddCell(tituloTotalSinIVA);

                        // Agregar encabezados de columna a la tabla con color
                        PdfPCell tituloTotal = new PdfPCell(new Phrase("Total"));
                        tituloTotal.BackgroundColor = colorTitulo;
                        tablaTotalesGenerales.AddCell(tituloTotal);

                        PdfPCell celdaTotalSinIVA = new PdfPCell(new Phrase($"{totalResumenSinIVA} €"));
                        celdaTotalSinIVA.BackgroundColor = colorCeldas;
                        tablaTotalesGenerales.AddCell(celdaTotalSinIVA);

                        // Agregar fila con los datos correspondientes a la tabla
                        PdfPCell celdaTotal = new PdfPCell(new Phrase($"{totalRecaudado} €"));
                        celdaTotal.BackgroundColor = colorCeldas;
                        tablaTotalesGenerales.AddCell(celdaTotal);

                        // Mostrar la tabla de totales generales
                        document.Add(tablaTotalesGenerales);



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
