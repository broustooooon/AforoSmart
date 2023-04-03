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
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.butImprimir = new System.Windows.Forms.Button();
            this.butGenerar = new System.Windows.Forms.Button();
            this.grbTicket = new System.Windows.Forms.GroupBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.butCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.grbTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgQR
            // 
            this.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQR.Location = new System.Drawing.Point(29, 21);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(265, 240);
            this.imgQR.TabIndex = 0;
            this.imgQR.TabStop = false;
            // 
            // butImprimir
            // 
            this.butImprimir.Enabled = false;
            this.butImprimir.Location = new System.Drawing.Point(216, 424);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(121, 43);
            this.butImprimir.TabIndex = 1;
            this.butImprimir.Text = "Imprimir";
            this.butImprimir.UseVisualStyleBackColor = true;
            this.butImprimir.Click += new System.EventHandler(this.butImprimir_Click);
            // 
            // butGenerar
            // 
            this.butGenerar.Location = new System.Drawing.Point(72, 424);
            this.butGenerar.Name = "butGenerar";
            this.butGenerar.Size = new System.Drawing.Size(121, 43);
            this.butGenerar.TabIndex = 2;
            this.butGenerar.Text = "Generar";
            this.butGenerar.UseVisualStyleBackColor = true;
            this.butGenerar.Click += new System.EventHandler(this.butGenerar_Click);
            // 
            // grbTicket
            // 
            this.grbTicket.Controls.Add(this.labelFechaInicio);
            this.grbTicket.Controls.Add(this.imgQR);
            this.grbTicket.Location = new System.Drawing.Point(43, 11);
            this.grbTicket.Name = "grbTicket";
            this.grbTicket.Size = new System.Drawing.Size(325, 393);
            this.grbTicket.TabIndex = 3;
            this.grbTicket.TabStop = false;
            this.grbTicket.Text = "Nuevo Ticket";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(26, 284);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(68, 20);
            this.labelFechaInicio.TabIndex = 1;
            this.labelFechaInicio.Text = "Desde: ";
            this.labelFechaInicio.Visible = false;
            // 
            // butCerrar
            // 
            this.butCerrar.Enabled = false;
            this.butCerrar.Location = new System.Drawing.Point(216, 494);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(121, 34);
            this.butCerrar.TabIndex = 4;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // NuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 540);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.grbTicket);
            this.Controls.Add(this.butGenerar);
            this.Controls.Add(this.butImprimir);
            this.Name = "NuevoTicket";
            this.Text = "NuevoTicket";
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.grbTicket.ResumeLayout(false);
            this.grbTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.Button butImprimir;
        private System.Windows.Forms.Button butGenerar;
        private System.Windows.Forms.GroupBox grbTicket;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Button butCerrar;
    }
}