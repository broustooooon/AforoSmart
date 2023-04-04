namespace ControlAforoTFG.Formularios
{
    partial class FormAjustes
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
            this.labelPrecioMinuto = new System.Windows.Forms.Label();
            this.textBoxPrecioMinuto = new System.Windows.Forms.TextBox();
            this.textBoxPrecioMediaHora = new System.Windows.Forms.TextBox();
            this.labelPrecioMediaHora = new System.Windows.Forms.Label();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.GuardarCerrar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrecioMinuto
            // 
            this.labelPrecioMinuto.AutoSize = true;
            this.labelPrecioMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMinuto.Location = new System.Drawing.Point(29, 63);
            this.labelPrecioMinuto.Name = "labelPrecioMinuto";
            this.labelPrecioMinuto.Size = new System.Drawing.Size(164, 25);
            this.labelPrecioMinuto.TabIndex = 0;
            this.labelPrecioMinuto.Text = "Precio por Minuto";
            // 
            // textBoxPrecioMinuto
            // 
            this.textBoxPrecioMinuto.Location = new System.Drawing.Point(299, 63);
            this.textBoxPrecioMinuto.Multiline = true;
            this.textBoxPrecioMinuto.Name = "textBoxPrecioMinuto";
            this.textBoxPrecioMinuto.Size = new System.Drawing.Size(125, 25);
            this.textBoxPrecioMinuto.TabIndex = 1;
            this.textBoxPrecioMinuto.TextChanged += new System.EventHandler(this.textBoxPrecioMinuto_TextChanged);
            // 
            // textBoxPrecioMediaHora
            // 
            this.textBoxPrecioMediaHora.Location = new System.Drawing.Point(299, 130);
            this.textBoxPrecioMediaHora.Multiline = true;
            this.textBoxPrecioMediaHora.Name = "textBoxPrecioMediaHora";
            this.textBoxPrecioMediaHora.Size = new System.Drawing.Size(125, 25);
            this.textBoxPrecioMediaHora.TabIndex = 3;
            this.textBoxPrecioMediaHora.TextChanged += new System.EventHandler(this.textBoxPrecioMediaHora_TextChanged);
            // 
            // labelPrecioMediaHora
            // 
            this.labelPrecioMediaHora.AutoSize = true;
            this.labelPrecioMediaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMediaHora.Location = new System.Drawing.Point(29, 130);
            this.labelPrecioMediaHora.Name = "labelPrecioMediaHora";
            this.labelPrecioMediaHora.Size = new System.Drawing.Size(206, 25);
            this.labelPrecioMediaHora.TabIndex = 2;
            this.labelPrecioMediaHora.Text = "Precio por Media Hora";
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Location = new System.Drawing.Point(299, 203);
            this.textBoxDescuento.Multiline = true;
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(125, 25);
            this.textBoxDescuento.TabIndex = 5;
            this.textBoxDescuento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(29, 199);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(106, 25);
            this.labelDescuento.TabIndex = 4;
            this.labelDescuento.Text = "Descuento\r\n";
            // 
            // GuardarCerrar
            // 
            this.GuardarCerrar.Enabled = false;
            this.GuardarCerrar.Location = new System.Drawing.Point(158, 505);
            this.GuardarCerrar.Name = "GuardarCerrar";
            this.GuardarCerrar.Size = new System.Drawing.Size(143, 32);
            this.GuardarCerrar.TabIndex = 6;
            this.GuardarCerrar.Text = "Guardar y Cerrar";
            this.GuardarCerrar.UseVisualStyleBackColor = true;
            this.GuardarCerrar.Click += new System.EventHandler(this.GuardarCerrar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Enabled = false;
            this.Guardar.Location = new System.Drawing.Point(34, 505);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(108, 32);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(316, 505);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(108, 32);
            this.butCancelar.TabIndex = 8;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.Color.Red;
            this.labelResultado.Location = new System.Drawing.Point(29, 450);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(251, 25);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Error al guardar los Ajustes.\r\n";
            this.labelResultado.Visible = false;
            // 
            // FormAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 563);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.GuardarCerrar);
            this.Controls.Add(this.textBoxDescuento);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.textBoxPrecioMediaHora);
            this.Controls.Add(this.labelPrecioMediaHora);
            this.Controls.Add(this.textBoxPrecioMinuto);
            this.Controls.Add(this.labelPrecioMinuto);
            this.Name = "FormAjustes";
            this.Text = "Ventana de Ajustes";
            this.Load += new System.EventHandler(this.FormAjustes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrecioMinuto;
        private System.Windows.Forms.TextBox textBoxPrecioMinuto;
        private System.Windows.Forms.TextBox textBoxPrecioMediaHora;
        private System.Windows.Forms.Label labelPrecioMediaHora;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Button GuardarCerrar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label labelResultado;
    }
}