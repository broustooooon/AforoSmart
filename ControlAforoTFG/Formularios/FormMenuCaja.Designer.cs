namespace ControlAforoTFG.Formularios
{
    partial class MenuCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCaja));
            this.butAbrirCaja = new System.Windows.Forms.Button();
            this.butCerrarCaja = new System.Windows.Forms.Button();
            this.butContarDinero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAbrirCaja
            // 
            this.butAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAbrirCaja.Location = new System.Drawing.Point(127, 89);
            this.butAbrirCaja.Name = "butAbrirCaja";
            this.butAbrirCaja.Size = new System.Drawing.Size(154, 56);
            this.butAbrirCaja.TabIndex = 0;
            this.butAbrirCaja.Text = "Abrir Caja";
            this.butAbrirCaja.UseVisualStyleBackColor = true;
            this.butAbrirCaja.Click += new System.EventHandler(this.butAbrirCaja_Click);
            // 
            // butCerrarCaja
            // 
            this.butCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCerrarCaja.Location = new System.Drawing.Point(127, 160);
            this.butCerrarCaja.Name = "butCerrarCaja";
            this.butCerrarCaja.Size = new System.Drawing.Size(154, 56);
            this.butCerrarCaja.TabIndex = 1;
            this.butCerrarCaja.Text = "Cerrar Caja";
            this.butCerrarCaja.UseVisualStyleBackColor = true;
            this.butCerrarCaja.Click += new System.EventHandler(this.butCerrarCaja_Click);
            // 
            // butContarDinero
            // 
            this.butContarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butContarDinero.Location = new System.Drawing.Point(127, 233);
            this.butContarDinero.Name = "butContarDinero";
            this.butContarDinero.Size = new System.Drawing.Size(154, 56);
            this.butContarDinero.TabIndex = 2;
            this.butContarDinero.Text = "Contar Dinero";
            this.butContarDinero.UseVisualStyleBackColor = true;
            this.butContarDinero.Click += new System.EventHandler(this.butContarDinero_Click);
            // 
            // MenuCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 519);
            this.Controls.Add(this.butContarDinero);
            this.Controls.Add(this.butCerrarCaja);
            this.Controls.Add(this.butAbrirCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCaja";
            this.Load += new System.EventHandler(this.MenuCaja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAbrirCaja;
        private System.Windows.Forms.Button butCerrarCaja;
        private System.Windows.Forms.Button butContarDinero;
    }
}