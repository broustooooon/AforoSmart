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
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.precioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butCobroTicket = new System.Windows.Forms.Button();
            this.butNuevoTicket = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.cobroToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.ajustesToolStripMenuItem1,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 710);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.nuevoToolStripMenuItem1.Text = "Generar Ticket";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.cobroToolStripMenuItem.Text = "Cobrar Ticket";
            this.cobroToolStripMenuItem.Click += new System.EventHandler(this.cobroToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ajustesToolStripMenuItem.Text = "Consultas";
            // 
            // ajustesToolStripMenuItem1
            // 
            this.ajustesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.precioToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.ajustesToolStripMenuItem1.Name = "ajustesToolStripMenuItem1";
            this.ajustesToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.ajustesToolStripMenuItem1.Text = "Ajustes";
            // 
            // precioToolStripMenuItem
            // 
            this.precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            this.precioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.precioToolStripMenuItem.Text = "Precio";
            this.precioToolStripMenuItem.Click += new System.EventHandler(this.precioToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.baseDeDatosToolStripMenuItem.Text = "Crear Base de Datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butCobroTicket, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butNuevoTicket, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(124, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 710);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // butCobroTicket
            // 
            this.butCobroTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butCobroTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCobroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCobroTicket.Location = new System.Drawing.Point(3, 358);
            this.butCobroTicket.Name = "butCobroTicket";
            this.butCobroTicket.Size = new System.Drawing.Size(311, 349);
            this.butCobroTicket.TabIndex = 1;
            this.butCobroTicket.Text = "Cobrar\r\nTicket";
            this.butCobroTicket.UseVisualStyleBackColor = false;
            this.butCobroTicket.Click += new System.EventHandler(this.butCobroTicket_Click);
            // 
            // butNuevoTicket
            // 
            this.butNuevoTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butNuevoTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butNuevoTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNuevoTicket.Location = new System.Drawing.Point(3, 3);
            this.butNuevoTicket.Name = "butNuevoTicket";
            this.butNuevoTicket.Size = new System.Drawing.Size(311, 349);
            this.butNuevoTicket.TabIndex = 0;
            this.butNuevoTicket.Text = "Generar\r\nTicket";
            this.butNuevoTicket.UseVisualStyleBackColor = false;
            this.butNuevoTicket.Click += new System.EventHandler(this.butNuevoTicket_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1143, 757);
            this.Name = "MainMenu";
            this.Text = "Control de Aforo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butCobroTicket;
        private System.Windows.Forms.Button butNuevoTicket;
    }
}

