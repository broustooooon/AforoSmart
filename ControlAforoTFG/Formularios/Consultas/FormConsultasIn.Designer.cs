namespace ControlAforoTFG.Formularios.Consultas
{
    partial class FormConsultasIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultasIn));
            this.controlAforoDataSet = new ControlAforoTFG.ControlAforoDataSet();
            this.ticketInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketInTableAdapter = new ControlAforoTFG.ControlAforoDataSetTableAdapters.TicketInTableAdapter();
            this.tableAdapterManager = new ControlAforoTFG.ControlAforoDataSetTableAdapters.TableAdapterManager();
            this.ticketInBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ticketInBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ticketInDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingNavigator)).BeginInit();
            this.ticketInBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlAforoDataSet
            // 
            this.controlAforoDataSet.DataSetName = "ControlAforoDataSet";
            this.controlAforoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketInBindingSource
            // 
            this.ticketInBindingSource.DataMember = "TicketIn";
            this.ticketInBindingSource.DataSource = this.controlAforoDataSet;
            // 
            // ticketInTableAdapter
            // 
            this.ticketInTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjustesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TicketInTableAdapter = this.ticketInTableAdapter;
            this.tableAdapterManager.TicketOutTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ControlAforoTFG.ControlAforoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketInBindingNavigator
            // 
            this.ticketInBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketInBindingNavigator.BindingSource = this.ticketInBindingSource;
            this.ticketInBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketInBindingNavigator.DeleteItem = null;
            this.ticketInBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ticketInBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticketInBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.ticketInBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketInBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketInBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketInBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketInBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketInBindingNavigator.Name = "ticketInBindingNavigator";
            this.ticketInBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketInBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.ticketInBindingNavigator.TabIndex = 0;
            this.ticketInBindingNavigator.Text = "bindingNavigator1";
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
            // ticketInBindingNavigatorSaveItem
            // 
            this.ticketInBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketInBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketInBindingNavigatorSaveItem.Image")));
            this.ticketInBindingNavigatorSaveItem.Name = "ticketInBindingNavigatorSaveItem";
            this.ticketInBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ticketInBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ticketInBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketInBindingNavigatorSaveItem_Click);
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
            // ticketInDataGridView
            // 
            this.ticketInDataGridView.AutoGenerateColumns = false;
            this.ticketInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketInDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ticketInDataGridView.DataSource = this.ticketInBindingSource;
            this.ticketInDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketInDataGridView.Location = new System.Drawing.Point(0, 27);
            this.ticketInDataGridView.Name = "ticketInDataGridView";
            this.ticketInDataGridView.RowHeadersWidth = 51;
            this.ticketInDataGridView.RowTemplate.Height = 24;
            this.ticketInDataGridView.Size = new System.Drawing.Size(800, 423);
            this.ticketInDataGridView.TabIndex = 1;
            this.ticketInDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketInDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "num_personas_in";
            this.dataGridViewTextBoxColumn2.HeaderText = "num_personas_in";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_entrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_entrada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // FormConsultasIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketInDataGridView);
            this.Controls.Add(this.ticketInBindingNavigator);
            this.Name = "FormConsultasIn";
            this.Text = "FormConsultasIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultasIn_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultasIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlAforoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInBindingNavigator)).EndInit();
            this.ticketInBindingNavigator.ResumeLayout(false);
            this.ticketInBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlAforoDataSet controlAforoDataSet;
        private System.Windows.Forms.BindingSource ticketInBindingSource;
        private ControlAforoDataSetTableAdapters.TicketInTableAdapter ticketInTableAdapter;
        private ControlAforoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketInBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticketInBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ticketInDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}