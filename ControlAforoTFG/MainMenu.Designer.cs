namespace ControlAforoTFG
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.ajustesToolStripMenuItem1,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cobrarToolStripMenuItem});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cobrarToolStripMenuItem
            // 
            this.cobrarToolStripMenuItem.Name = "cobrarToolStripMenuItem";
            this.cobrarToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.cobrarToolStripMenuItem.Text = "Cobrar";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.ajustesToolStripMenuItem.Text = "Consultas";
            // 
            // ajustesToolStripMenuItem1
            // 
            this.ajustesToolStripMenuItem1.Name = "ajustesToolStripMenuItem1";
            this.ajustesToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.ajustesToolStripMenuItem1.Text = "Ajustes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Control de Aforo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

