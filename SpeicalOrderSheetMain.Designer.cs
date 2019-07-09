namespace Sturdevant_s_Application
{
    partial class SpeicalOrderSheetMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeicalOrderSheetMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specialOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIS248_ProjectDataSet = new Sturdevant_s_Application.CIS248_ProjectDataSet();
            this.special_OrdersTableAdapter = new Sturdevant_s_Application.CIS248_ProjectDataSetTableAdapters.Special_OrdersTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Update = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS248_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rushDataGridViewTextBoxColumn,
            this.vendorNameShortDataGridViewTextBoxColumn,
            this.actName,
            this.ticketNumberDataGridViewTextBoxColumn,
            this.partNumberDataGridViewTextBoxColumn,
            this.orderQtyDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn,
            this.whoOrderedDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.poNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specialOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1186, 554);
            this.dataGridView1.TabIndex = 1;
            // 
            // specialOrdersBindingSource
            // 
            this.specialOrdersBindingSource.DataMember = "Special_Orders";
            this.specialOrdersBindingSource.DataSource = this.cIS248_ProjectDataSet;
            // 
            // cIS248_ProjectDataSet
            // 
            this.cIS248_ProjectDataSet.DataSetName = "CIS248_ProjectDataSet";
            this.cIS248_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // special_OrdersTableAdapter
            // 
            this.special_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.specialOrdersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripButton_Save,
            this.toolStripButton_Update});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1186, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "toolStripButton1";
            this.toolStripButton_Save.Click += new System.EventHandler(this.ToolStripButton_Save_Click);
            // 
            // toolStripButton_Update
            // 
            this.toolStripButton_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Update.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Update.Image")));
            this.toolStripButton_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Update.Name = "toolStripButton_Update";
            this.toolStripButton_Update.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Update.Text = "toolStripButton2";
            this.toolStripButton_Update.Click += new System.EventHandler(this.ToolStripButton_Update_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Row Number";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // rushDataGridViewTextBoxColumn
            // 
            this.rushDataGridViewTextBoxColumn.DataPropertyName = "rush";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rushDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rushDataGridViewTextBoxColumn.Frozen = true;
            this.rushDataGridViewTextBoxColumn.HeaderText = "Rush";
            this.rushDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.rushDataGridViewTextBoxColumn.Name = "rushDataGridViewTextBoxColumn";
            this.rushDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rushDataGridViewTextBoxColumn.Width = 45;
            // 
            // vendorNameShortDataGridViewTextBoxColumn
            // 
            this.vendorNameShortDataGridViewTextBoxColumn.DataPropertyName = "vendorNameShort";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vendorNameShortDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.vendorNameShortDataGridViewTextBoxColumn.Frozen = true;
            this.vendorNameShortDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorNameShortDataGridViewTextBoxColumn.Name = "vendorNameShortDataGridViewTextBoxColumn";
            this.vendorNameShortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorNameShortDataGridViewTextBoxColumn.Width = 110;
            // 
            // actName
            // 
            this.actName.DataPropertyName = "actName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.actName.DefaultCellStyle = dataGridViewCellStyle4;
            this.actName.Frozen = true;
            this.actName.HeaderText = "Customer";
            this.actName.Name = "actName";
            this.actName.Width = 150;
            // 
            // ticketNumberDataGridViewTextBoxColumn
            // 
            this.ticketNumberDataGridViewTextBoxColumn.DataPropertyName = "ticketNumber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ticketNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ticketNumberDataGridViewTextBoxColumn.Frozen = true;
            this.ticketNumberDataGridViewTextBoxColumn.HeaderText = "Ticket #";
            this.ticketNumberDataGridViewTextBoxColumn.Name = "ticketNumberDataGridViewTextBoxColumn";
            this.ticketNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "partNumber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.partNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.partNumberDataGridViewTextBoxColumn.Frozen = true;
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "Part #";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            this.partNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderQtyDataGridViewTextBoxColumn
            // 
            this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "orderQty";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.orderQtyDataGridViewTextBoxColumn.Frozen = true;
            this.orderQtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
            this.orderQtyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderQtyDataGridViewTextBoxColumn.Width = 35;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.notesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.notesDataGridViewTextBoxColumn.Frozen = true;
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notesDataGridViewTextBoxColumn.Width = 175;
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "initials";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.initialsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.initialsDataGridViewTextBoxColumn.Frozen = true;
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Who Placed The Order";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            this.initialsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.initialsDataGridViewTextBoxColumn.Width = 65;
            // 
            // whoOrderedDataGridViewTextBoxColumn
            // 
            this.whoOrderedDataGridViewTextBoxColumn.DataPropertyName = "whoOrdered";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.whoOrderedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.whoOrderedDataGridViewTextBoxColumn.Frozen = true;
            this.whoOrderedDataGridViewTextBoxColumn.HeaderText = "Who Ordered";
            this.whoOrderedDataGridViewTextBoxColumn.Name = "whoOrderedDataGridViewTextBoxColumn";
            this.whoOrderedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.whoOrderedDataGridViewTextBoxColumn.Width = 65;
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "dateOrdered";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateOrderedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.dateOrderedDataGridViewTextBoxColumn.Frozen = true;
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            this.dateOrderedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateOrderedDataGridViewTextBoxColumn.Width = 75;
            // 
            // poNumberDataGridViewTextBoxColumn
            // 
            this.poNumberDataGridViewTextBoxColumn.DataPropertyName = "poNumber";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.poNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.poNumberDataGridViewTextBoxColumn.Frozen = true;
            this.poNumberDataGridViewTextBoxColumn.HeaderText = "PO # or REF #";
            this.poNumberDataGridViewTextBoxColumn.Name = "poNumberDataGridViewTextBoxColumn";
            this.poNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.poNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // SpeicalOrderSheetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpeicalOrderSheetMain";
            this.Size = new System.Drawing.Size(1186, 621);
            this.Load += new System.EventHandler(this.SpeicalOrderSheetMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIS248_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource specialOrdersBindingSource;
        private CIS248_ProjectDataSet cIS248_ProjectDataSet;
        private CIS248_ProjectDataSetTableAdapters.Special_OrdersTableAdapter special_OrdersTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn actNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poNumberDataGridViewTextBoxColumn;
    }
}
