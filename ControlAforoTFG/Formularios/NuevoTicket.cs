
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
        private DateTime fecha;
        // Crea una instancia de PrintDocument
        private PrintDocument printDocument1 = new PrintDocument();

        public NuevoTicket()
        {
            InitializeComponent();
        }

        /*Boton Generar*/
        private void butGenerar_Click(object sender, EventArgs e)
        {
            generarQR();
            butGenerar.Enabled = false;
        }

        /*Boton Imprimir*/
        private void butImprimir_Click(object sender, EventArgs e)
        {
            /*Guardar en Base de Datos*/
            GenerarCodigoUnico(fecha);

            /*Imprimir Ticket*/
            //ImprimirFormulario();
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);

        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        /*Boton Cerrar*/
        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            labelFechaInicio.Text += fecha.ToString();
            labelFechaInicio.Visible = true;
            butImprimir.Enabled = true;
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


        // Manejador de eventos para el evento PrintPage
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibuja el formulario en el objeto Graphics de la página de impresión
            e.Graphics.DrawImage(this.grbTicket.BackgroundImage, 0, 0, e.PageSettings.PrintableArea.Width, e.PageSettings.PrintableArea.Height);
        }
    }
}
