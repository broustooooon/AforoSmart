using QRCoder;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;

namespace ControlAforoTFG.Formularios
{
    public partial class FormNuevoTicket : Form
    {
        /*Propiedades*/
        private DateTime fecha;
        private Bitmap memoryImg;

        public FormNuevoTicket()
        {
            InitializeComponent();
        }

        private void NuevoTicket_Load(object sender, EventArgs e)
        {
            generarQR();
        }

        /*Boton Imprimir*/
        private void butImprimir_Click(object sender, EventArgs e)
        {
            if (numPersonas.Value <= 0)
            {
                DialogResult result = MessageBox.Show("Introduzca un número de personas válido", 
                                                      "Error", 
                                                      MessageBoxButtons.OK, 
                                                      MessageBoxIcon.Error);
            }
            else {
                ConectionDB conection = new ConectionDB();
                int aforoDisponible = conection.calcularAforo();
                if (aforoDisponible < Convert.ToInt32(numPersonas.Value))
                {
                    DialogResult result = MessageBox.Show(("No hay espacio disponible (Aforo disponible: " + aforoDisponible + ")"),
                                                      "Error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                } else
                {
                    /*Crea el Ticket*/
                    TicketIn ticket = new TicketIn(GenerarCodigoUnico(fecha), fecha, Convert.ToInt32(numPersonas.Value));

                    /*Guarda el Ticket en base de datos*/
                    conection.GuardarTicketIn(ticket);

                    /*Imprimir Ticket*/
                    for (int i = 0; i < ticket.NumPersonasIn; i++)
                    {
                        Print(panelPrint);
                    }
                    FormControlAforo.actualizarAforo();
                    this.Close();
                }
            }
        }


        /*---Metodos---*/
        private void generarQR()
        {
            fecha = capturarFecha();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(fecha.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4, Color.Black, Color.White, null, 15, 6, false);

            // Redimensiona la imagen a un tamaño fijo de 200 x 200 sin relación de aspecto
            Bitmap resizedImage = new Bitmap(qrCodeImage, 200, 200);

            /*Ajustamos Contenedor de la Imagen al QR Generado*/
            imgQR.Size = resizedImage.Size;

            // Asigna la imagen generada al PictureBox
            imgQR.Image = resizedImage;

            labelFecha.Text += fecha.ToShortDateString();
            labelHora.Text += fecha.ToString("HH:mm:ss");
            labelFecha.Visible = true;
            labelFecha.Visible = true;
            labelHora.Visible = true;
            labelNumPersonas.Visible = true;
            butImprimir.Enabled = true;
        }

        private DateTime capturarFecha()
        {
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.AddHours(-2);
            return dateTime;
        }

        public static string GenerarCodigoUnico(DateTime fecha)
        {
            // Convierte el objeto DateTime a una cadena de caracteres con el formato deseado
            string fechaStr = fecha.ToString("yyyyMMddHHmmss");

            // Calcula un valor de hash único basado en la cadena de caracteres de la fecha
            byte[] hashBytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(fechaStr));
            string hashStr = BitConverter.ToString(hashBytes).Replace("-", "");

            // Devuelve los primeros 8 caracteres del valor de hash como el código único
            return hashStr.Substring(0, 8);
        }

        private void Print(Panel pnl)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];
            printDoc.PrintController = new StandardPrintController();
            panelPrint = pnl;
            getPrintArea(pnl);
            printDoc.PrintPage += new PrintPageEventHandler(printTicket_PrintPage);
            printDoc.Print();
        }

        private void getPrintArea(Panel pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pagearea.Width/2) - (this.panelPrint.Width/2), this.panelPrint.Location.Y);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numPersonas_ValueChanged(object sender, EventArgs e)
        {
            labelNumPersonas.Text = "Nº Personas: " + numPersonas.Value.ToString();
        }
    }
}
