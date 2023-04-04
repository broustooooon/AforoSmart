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
            this.butImprimir = new System.Windows.Forms.Button();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.labelNumPersonas = new System.Windows.Forms.Label();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // butImprimir
            // 
            this.butImprimir.Enabled = false;
            this.butImprimir.Location = new System.Drawing.Point(242, 447);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(121, 32);
            this.butImprimir.TabIndex = 1;
            this.butImprimir.Text = "Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            this.butImprimir.Click += new System.EventHandler(this.butImprimir_Click);
            // 
            // printTicket
            // 
            this.printTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTicket_PrintPage);
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.labelNumPersonas);
            this.panelPrint.Controls.Add(this.labelHora);
            this.panelPrint.Controls.Add(this.labelFecha);
            this.panelPrint.Controls.Add(this.imgQR);
            this.panelPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrint.Location = new System.Drawing.Point(0, 0);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(410, 379);
            this.panelPrint.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(70, 310);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(56, 20);
            this.labelHora.TabIndex = 9;
            this.labelHora.Text = "Hora: ";
            this.labelHora.Visible = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(70, 277);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(65, 20);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "Fecha: ";
            this.labelFecha.Visible = false;
            // 
            // imgQR
            // 
            this.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQR.Location = new System.Drawing.Point(74, 25);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(265, 240);
            this.imgQR.TabIndex = 7;
            this.imgQR.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(50, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de Personas:";
            // 
            // numPersonas
            // 
            this.numPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPersonas.Location = new System.Drawing.Point(243, 404);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 27);
            this.numPersonas.TabIndex = 10;
            this.numPersonas.ValueChanged += new System.EventHandler(this.numPersonas_ValueChanged);
            // 
            // labelNumPersonas
            // 
            this.labelNumPersonas.AutoSize = true;
            this.labelNumPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPersonas.Location = new System.Drawing.Point(70, 340);
            this.labelNumPersonas.Name = "labelNumPersonas";
            this.labelNumPersonas.Size = new System.Drawing.Size(113, 20);
            this.labelNumPersonas.TabIndex = 10;
            this.labelNumPersonas.Text = "Nº Personas: ";
            this.labelNumPersonas.Visible = false;
            // 
            // NuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 506);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.butImprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NuevoTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoTicket";
            this.Load += new System.EventHandler(this.NuevoTicket_Load);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butImprimir;
        private System.Drawing.Printing.PrintDocument printTicket;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label labelNumPersonas;
    }
}