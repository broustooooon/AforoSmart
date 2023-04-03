
using QRCoder;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ControlAforoTFG.Formularios
{
    public partial class NuevoTicket : Form
    {
        /*Propiedades*/
        private DateTime fecha;
        private Bitmap memoryImg;

        public NuevoTicket()
        {
            InitializeComponent();
        }

        /*Boton Generar*/
        private void butGenerar_Click(object sender, EventArgs e)
        {
            //if(!textBoxPersonas.Text.Equals(""))
            //{
            //    try
            //    {
            //        generarQR();
            //    }
            //    catch 
            //    {

            //    }
            //}

            generarQR();
        }

        /*Boton Imprimir*/
        private void butImprimir_Click(object sender, EventArgs e)
        {
            /*Guardar en Base de Datos*/
            GenerarCodigoUnico(fecha);

            /*Imprimir Ticket*/
            Print(panelPrint);

            this.Close();
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
            butImprimir.Enabled = true;
            butGenerar.Enabled = false;
        }

        private DateTime capturarFecha()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime;
        }

        private string GenerarCodigoUnico(DateTime fecha)
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
    }
}
