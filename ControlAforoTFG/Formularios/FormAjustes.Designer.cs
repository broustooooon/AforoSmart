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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjustes));
            this.labelPrecioMinuto = new System.Windows.Forms.Label();
            this.textBoxPrecioMinuto = new System.Windows.Forms.TextBox();
            this.textBoxPrecioMediaHora = new System.Windows.Forms.TextBox();
            this.labelPrecioMediaHora = new System.Windows.Forms.Label();
            this.GuardarCerrar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxAforo = new System.Windows.Forms.TextBox();
            this.labelAforo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDinero = new System.Windows.Forms.TextBox();
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
            this.textBoxPrecioMinuto.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxPrecioMinuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // textBoxPrecioMediaHora
            // 
            this.textBoxPrecioMediaHora.Location = new System.Drawing.Point(299, 130);
            this.textBoxPrecioMediaHora.Multiline = true;
            this.textBoxPrecioMediaHora.Name = "textBoxPrecioMediaHora";
            this.textBoxPrecioMediaHora.Size = new System.Drawing.Size(125, 25);
            this.textBoxPrecioMediaHora.TabIndex = 3;
            this.textBoxPrecioMediaHora.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxPrecioMediaHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labelPrecioMediaHora
            // 
            this.labelPrecioMediaHora.AutoSize = true;
            this.labelPrecioMediaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMediaHora.Location = new System.Drawing.Point(29, 130);
            this.labelPrecioMediaHora.Name = "labelPrecioMediaHora";
            this.labelPrecioMediaHora.Size = new System.Drawing.Size(245, 25);
            this.labelPrecioMediaHora.TabIndex = 2;
            this.labelPrecioMediaHora.Text = "Precio Primera Media Hora";
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
            // textBoxAforo
            // 
            this.textBoxAforo.Location = new System.Drawing.Point(299, 197);
            this.textBoxAforo.Multiline = true;
            this.textBoxAforo.Name = "textBoxAforo";
            this.textBoxAforo.Size = new System.Drawing.Size(125, 25);
            this.textBoxAforo.TabIndex = 10;
            this.textBoxAforo.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxAforo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labelAforo
            // 
            this.labelAforo.AutoSize = true;
            this.labelAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAforo.Location = new System.Drawing.Point(29, 197);
            this.labelAforo.Name = "labelAforo";
            this.labelAforo.Size = new System.Drawing.Size(133, 25);
            this.labelAforo.TabIndex = 11;
            this.labelAforo.Text = "Aforo Máximo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dinero Introducido";
            // 
            // textBoxDinero
            // 
            this.textBoxDinero.Location = new System.Drawing.Point(299, 269);
            this.textBoxDinero.Multiline = true;
            this.textBoxDinero.Name = "textBoxDinero";
            this.textBoxDinero.Size = new System.Drawing.Size(125, 25);
            this.textBoxDinero.TabIndex = 12;
            this.textBoxDinero.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // FormAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDinero);
            this.Controls.Add(this.labelAforo);
            this.Controls.Add(this.textBoxAforo);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.GuardarCerrar);
            this.Controls.Add(this.textBoxPrecioMediaHora);
            this.Controls.Add(this.labelPrecioMediaHora);
            this.Controls.Add(this.textBoxPrecioMinuto);
            this.Controls.Add(this.labelPrecioMinuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button GuardarCerrar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxAforo;
        private System.Windows.Forms.Label labelAforo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDinero;
    }
}
