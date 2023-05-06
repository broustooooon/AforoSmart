namespace ControlAforoTFG.Formularios
{
    partial class FormCobro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFechaEntrada = new System.Windows.Forms.TextBox();
            this.butCobrar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.radioTarjeta = new System.Windows.Forms.RadioButton();
            this.radioEfectivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Personas";
            // 
            // textBoxFechaEntrada
            // 
            this.textBoxFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaEntrada.Location = new System.Drawing.Point(93, 118);
            this.textBoxFechaEntrada.Multiline = true;
            this.textBoxFechaEntrada.Name = "textBoxFechaEntrada";
            this.textBoxFechaEntrada.Size = new System.Drawing.Size(233, 35);
            this.textBoxFechaEntrada.TabIndex = 2;
            this.textBoxFechaEntrada.TextChanged += new System.EventHandler(this.textBoxFechaEntrada_TextChanged);
            // 
            // butCobrar
            // 
            this.butCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCobrar.Location = new System.Drawing.Point(221, 403);
            this.butCobrar.Name = "butCobrar";
            this.butCobrar.Size = new System.Drawing.Size(177, 61);
            this.butCobrar.TabIndex = 3;
            this.butCobrar.Text = "Cobrar";
            this.butCobrar.UseVisualStyleBackColor = true;
            this.butCobrar.Click += new System.EventHandler(this.butCobrar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelar.Location = new System.Drawing.Point(12, 403);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(177, 61);
            this.butCancelar.TabIndex = 4;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // numPersonas
            // 
            this.numPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPersonas.Location = new System.Drawing.Point(241, 187);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(131, 30);
            this.numPersonas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Entrada";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFecha.Location = new System.Drawing.Point(50, 41);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(310, 22);
            this.dateTimeFecha.TabIndex = 9;
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
            // 
            // radioTarjeta
            // 
            this.radioTarjeta.AutoSize = true;
            this.radioTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTarjeta.Location = new System.Drawing.Point(258, 291);
            this.radioTarjeta.Name = "radioTarjeta";
            this.radioTarjeta.Size = new System.Drawing.Size(94, 29);
            this.radioTarjeta.TabIndex = 14;
            this.radioTarjeta.TabStop = true;
            this.radioTarjeta.Text = "Tarjeta";
            this.radioTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioEfectivo
            // 
            this.radioEfectivo.AutoSize = true;
            this.radioEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEfectivo.Location = new System.Drawing.Point(258, 253);
            this.radioEfectivo.Name = "radioEfectivo";
            this.radioEfectivo.Size = new System.Drawing.Size(102, 29);
            this.radioEfectivo.TabIndex = 13;
            this.radioEfectivo.TabStop = true;
            this.radioEfectivo.Text = "Efectivo";
            this.radioEfectivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Forma de Pago";
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 506);
            this.Controls.Add(this.radioTarjeta);
            this.Controls.Add(this.radioEfectivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butCobrar);
            this.Controls.Add(this.textBoxFechaEntrada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCobro";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFechaEntrada;
        private System.Windows.Forms.Button butCobrar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.RadioButton radioTarjeta;
        private System.Windows.Forms.RadioButton radioEfectivo;
        private System.Windows.Forms.Label label2;
    }
}