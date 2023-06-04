namespace ControlAforoTFG.Formularios
{
    partial class FormConsultasOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultasOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ticketOutBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ticketOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlAforoDataSet = new ControlAforoTFG.ControlAforoDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketOutBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ticketOutDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketOutTableAdapter = new ControlAforoTFG.ControlAforoDataSetTableAdapters.TicketOutTableAdapter();
            this.tableAdapterManager = new ControlAforoTFG.ControlAforoDataSetTableAdapters.TableAdapterManager();
            this.ticketInTableAdapter = new ControlAforoTFG.ControlAforoDataSetTableAdapters.TicketInTableAdapter();
            this.ticketInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutBindingNavigator)).BeginInit();
            this.ticketOutBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketOutBindingNavigator
            // 
            this.ticketOutBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketOutBindingNavigator.BindingSource = this.ticketOutBindingSource;
            this.ticketOutBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketOutBindingNavigator.DeleteItem = null;
            this.ticketOutBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ticketOutBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.ticketOutBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.ticketOutBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketOutBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketOutBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketOutBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketOutBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketOutBindingNavigator.Name = "ticketOutBindingNavigator";
            this.ticketOutBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketOutBindingNavigator.Size = new System.Drawing.Size(1075, 27);
            this.ticketOutBindingNavigator.TabIndex = 0;
            this.ticketOutBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // ticketOutBindingSource
            // 
            this.ticketOutBindingSource.DataMember = "TicketOut";
            this.ticketOutBindingSource.DataSource = this.controlAforoDataSet;
            // 
            // controlAforoDataSet
            // 
            this.controlAforoDataSet.DataSetName = "ControlAforoDataSet";
            this.controlAforoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ticketOutBindingNavigatorSaveItem
            // 
            this.ticketOutBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketOutBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketOutBindingNavigatorSaveItem.Image")));
            this.ticketOutBindingNavigatorSaveItem.Name = "ticketOutBindingNavigatorSaveItem";
            this.ticketOutBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ticketOutBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ticketOutBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketOutBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ControlAforoTFG.Properties.Resources.Red_Cross_PNG_Photo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ticketOutDataGridView
            // 
            this.ticketOutDataGridView.AutoGenerateColumns = false;
            this.ticketOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ticketOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.tipo_descuento,
            this.dataGridViewTextBoxColumn7,
            this.estado,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.ticketOutDataGridView.DataSource = this.ticketOutBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketOutDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ticketOutDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketOutDataGridView.Location = new System.Drawing.Point(0, 27);
            this.ticketOutDataGridView.Name = "ticketOutDataGridView";
            this.ticketOutDataGridView.RowHeadersWidth = 51;
            this.ticketOutDataGridView.RowTemplate.Height = 24;
            this.ticketOutDataGridView.Size = new System.Drawing.Size(1075, 599);
            this.ticketOutDataGridView.TabIndex = 1;
            this.ticketOutDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketOutDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_entrada";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_entrada";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_salida";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_salida";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tipo_descuento
            // 
            this.tipo_descuento.DataPropertyName = "tipo_descuento";
            this.tipo_descuento.HeaderText = "tipo_descuento";
            this.tipo_descuento.MinimumWidth = 6;
            this.tipo_descuento.Name = "tipo_descuento";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "metodo_pago";
            this.dataGridViewTextBoxColumn7.HeaderText = "metodo_pago";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "num_personas_out";
            this.dataGridViewTextBoxColumn3.HeaderText = "num_personas_out";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "importe";
            this.dataGridViewTextBoxColumn6.HeaderText = "importe";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ticketOutTableAdapter
            // 
            this.ticketOutTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjustesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IncidenciasTableAdapter = null;
            this.tableAdapterManager.RegistroCajaTableAdapter = null;
            this.tableAdapterManager.TicketInTableAdapter = this.ticketInTableAdapter;
            this.tableAdapterManager.TicketOutTableAdapter = this.ticketOutTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControlAforoTFG.ControlAforoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketInTableAdapter
            // 
            this.ticketInTableAdapter.ClearBeforeFill = true;
            // 
            // ticketInBindingSource
            // 
            this.ticketInBindingSource.DataMember = "TicketIn";
            this.ticketInBindingSource.DataSource = this.controlAforoDataSet;
            // 
            // FormConsultasOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 626);
            this.Controls.Add(this.ticketOutDataGridView);
            this.Controls.Add(this.ticketOutBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultasOut";
            this.Text = "FormConsultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultasOut_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutBindingNavigator)).EndInit();
            this.ticketOutBindingNavigator.ResumeLayout(false);
            this.ticketOutBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlAforoDataSet controlAforoDataSet;
        private System.Windows.Forms.BindingSource ticketOutBindingSource;
        private ControlAforoDataSetTableAdapters.TicketOutTableAdapter ticketOutTableAdapter;
        private ControlAforoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketOutBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ticketOutBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ControlAforoDataSetTableAdapters.TicketInTableAdapter ticketInTableAdapter;
        private System.Windows.Forms.BindingSource ticketInBindingSource;
        private System.Windows.Forms.DataGridView ticketOutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}