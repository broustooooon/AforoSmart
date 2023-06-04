namespace ControlAforoTFG.Formularios.Consultas
{
    partial class RegistroCaja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCaja));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinerointroducidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efectivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlAforoDataSet = new ControlAforoTFG.ControlAforoDataSet();
            this.registroCajaTableAdapter = new ControlAforoTFG.ControlAforoDataSetTableAdapters.RegistroCajaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.dinerointroducidoDataGridViewTextBoxColumn,
            this.efectivoDataGridViewTextBoxColumn,
            this.otrosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registroCajaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dinerointroducidoDataGridViewTextBoxColumn
            // 
            this.dinerointroducidoDataGridViewTextBoxColumn.DataPropertyName = "dinero_introducido";
            this.dinerointroducidoDataGridViewTextBoxColumn.HeaderText = "dinero_introducido";
            this.dinerointroducidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinerointroducidoDataGridViewTextBoxColumn.Name = "dinerointroducidoDataGridViewTextBoxColumn";
            this.dinerointroducidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // efectivoDataGridViewTextBoxColumn
            // 
            this.efectivoDataGridViewTextBoxColumn.DataPropertyName = "efectivo";
            this.efectivoDataGridViewTextBoxColumn.HeaderText = "efectivo";
            this.efectivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.efectivoDataGridViewTextBoxColumn.Name = "efectivoDataGridViewTextBoxColumn";
            this.efectivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otrosDataGridViewTextBoxColumn
            // 
            this.otrosDataGridViewTextBoxColumn.DataPropertyName = "otros";
            this.otrosDataGridViewTextBoxColumn.HeaderText = "otros";
            this.otrosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otrosDataGridViewTextBoxColumn.Name = "otrosDataGridViewTextBoxColumn";
            this.otrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroCajaBindingSource
            // 
            this.registroCajaBindingSource.DataMember = "RegistroCaja";
            this.registroCajaBindingSource.DataSource = this.controlAforoDataSet;
            // 
            // controlAforoDataSet
            // 
            this.controlAforoDataSet.DataSetName = "ControlAforoDataSet";
            this.controlAforoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroCajaTableAdapter
            // 
            this.registroCajaTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroCaja";
            this.Text = "RegistroCaja";
            this.Load += new System.EventHandler(this.RegistroCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlAforoDataSet controlAforoDataSet;
        private System.Windows.Forms.BindingSource registroCajaBindingSource;
        private ControlAforoDataSetTableAdapters.RegistroCajaTableAdapter registroCajaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinerointroducidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}