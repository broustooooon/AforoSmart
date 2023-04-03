namespace ControlAforoTFG.Formularios
{
    partial class NuevoTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoTicket));
            this.butImprimir = new System.Windows.Forms.Button();
            this.butGenerar = new System.Windows.Forms.Button();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.SuspendLayout();
            // 
            // butImprimir
            // 
            this.butImprimir.Enabled = false;
            this.butImprimir.Location = new System.Drawing.Point(216, 440);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(121, 43);
            this.butImprimir.TabIndex = 1;
            this.butImprimir.Text = "Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            this.butImprimir.Click += new System.EventHandler(this.butImprimir_Click);
            // 
            // butGenerar
            // 
            this.butGenerar.Location = new System.Drawing.Point(72, 440);
            this.butGenerar.Name = "butGenerar";
            this.butGenerar.Size = new System.Drawing.Size(121, 43);
            this.butGenerar.TabIndex = 2;
            this.butGenerar.Text = "Generar";
            this.butGenerar.UseVisualStyleBackColor = true;
            this.butGenerar.Click += new System.EventHandler(this.butGenerar_Click);
            // 
            // printTicket
            // 
            this.printTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTicket_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printTicket;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.labelFechaInicio);
            this.panelPrint.Controls.Add(this.imgQR);
            this.panelPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrint.Location = new System.Drawing.Point(0, 0);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(410, 406);
            this.panelPrint.TabIndex = 3;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(69, 314);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(68, 20);
            this.labelFechaInicio.TabIndex = 8;
            this.labelFechaInicio.Text = "Desde: ";
            this.labelFechaInicio.Visible = false;
            // 
            // imgQR
            // 
            this.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQR.Location = new System.Drawing.Point(72, 51);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(265, 240);
            this.imgQR.TabIndex = 7;
            this.imgQR.TabStop = false;
            // 
            // NuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 540);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.butGenerar);
            this.Controls.Add(this.butImprimir);
            this.Name = "NuevoTicket";
            this.Text = "NuevoTicket";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butImprimir;
        private System.Windows.Forms.Button butGenerar;
        private System.Drawing.Printing.PrintDocument printTicket;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.PictureBox imgQR;
    }
}