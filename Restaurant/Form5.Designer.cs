namespace Restaurant
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label eMP_IDLabel;
            System.Windows.Forms.Label eMP_FNAMELabel;
            System.Windows.Forms.Label eMP_LNAMELabel;
            System.Windows.Forms.Label cONTACTLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label sEXLabel;
            System.Windows.Forms.Label mERITAL_STATUSLabel;
            System.Windows.Forms.Label pOSITIONLabel;
            System.Windows.Forms.Label bASIC_SALARYLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label uSER_IDLabel;
            this.myRestaurantDataSet1 = new Restaurant.MyRestaurantDataSet1();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Restaurant.MyRestaurantDataSet1TableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager();
            this.eMPLOYEEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eMPLOYEEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMP_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMP_FNAMETextBox = new System.Windows.Forms.TextBox();
            this.eMP_LNAMETextBox = new System.Windows.Forms.TextBox();
            this.cONTACTTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.sEXTextBox = new System.Windows.Forms.TextBox();
            this.mERITAL_STATUSTextBox = new System.Windows.Forms.TextBox();
            this.pOSITIONTextBox = new System.Windows.Forms.TextBox();
            this.bASIC_SALARYTextBox = new System.Windows.Forms.TextBox();
            this.dOBTextBox = new System.Windows.Forms.TextBox();
            this.uSER_IDTextBox = new System.Windows.Forms.TextBox();
            eMP_IDLabel = new System.Windows.Forms.Label();
            eMP_FNAMELabel = new System.Windows.Forms.Label();
            eMP_LNAMELabel = new System.Windows.Forms.Label();
            cONTACTLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            sEXLabel = new System.Windows.Forms.Label();
            mERITAL_STATUSLabel = new System.Windows.Forms.Label();
            pOSITIONLabel = new System.Windows.Forms.Label();
            bASIC_SALARYLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            uSER_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).BeginInit();
            this.eMPLOYEEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myRestaurantDataSet1
            // 
            this.myRestaurantDataSet1.DataSetName = "MyRestaurantDataSet1";
            this.myRestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.myRestaurantDataSet1;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISHTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.MadeTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLOYEEBindingNavigator
            // 
            this.eMPLOYEEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLOYEEBindingNavigator.BindingSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLOYEEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLOYEEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPLOYEEBindingNavigatorSaveItem});
            this.eMPLOYEEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLOYEEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLOYEEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLOYEEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLOYEEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLOYEEBindingNavigator.Name = "eMPLOYEEBindingNavigator";
            this.eMPLOYEEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLOYEEBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.eMPLOYEEBindingNavigator.TabIndex = 0;
            this.eMPLOYEEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // eMPLOYEEBindingNavigatorSaveItem
            // 
            this.eMPLOYEEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEEBindingNavigatorSaveItem.Name = "eMPLOYEEBindingNavigatorSaveItem";
            this.eMPLOYEEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLOYEEBindingNavigatorSaveItem.Text = "Save Data";
            this.eMPLOYEEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLOYEEBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.eMPLOYEEDataGridView.DataSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(244, 44);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(373, 184);
            this.eMPLOYEEDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMP_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EMP_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EMP_FNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "EMP_FNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMP_LNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMP_LNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CONTACT";
            this.dataGridViewTextBoxColumn4.HeaderText = "CONTACT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn5.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SEX";
            this.dataGridViewTextBoxColumn6.HeaderText = "SEX";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MERITAL_STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "MERITAL_STATUS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "POSITION";
            this.dataGridViewTextBoxColumn8.HeaderText = "POSITION";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BASIC_SALARY";
            this.dataGridViewTextBoxColumn9.HeaderText = "BASIC_SALARY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn10.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "USER_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "USER_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // eMP_IDLabel
            // 
            eMP_IDLabel.AutoSize = true;
            eMP_IDLabel.Location = new System.Drawing.Point(12, 43);
            eMP_IDLabel.Name = "eMP_IDLabel";
            eMP_IDLabel.Size = new System.Drawing.Size(47, 13);
            eMP_IDLabel.TabIndex = 24;
            eMP_IDLabel.Text = "EMP ID:";
            // 
            // eMP_IDTextBox
            // 
            this.eMP_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMP_ID", true));
            this.eMP_IDTextBox.Location = new System.Drawing.Point(121, 40);
            this.eMP_IDTextBox.Name = "eMP_IDTextBox";
            this.eMP_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_IDTextBox.TabIndex = 25;
            // 
            // eMP_FNAMELabel
            // 
            eMP_FNAMELabel.AutoSize = true;
            eMP_FNAMELabel.Location = new System.Drawing.Point(12, 69);
            eMP_FNAMELabel.Name = "eMP_FNAMELabel";
            eMP_FNAMELabel.Size = new System.Drawing.Size(73, 13);
            eMP_FNAMELabel.TabIndex = 26;
            eMP_FNAMELabel.Text = "EMP FNAME:";
            // 
            // eMP_FNAMETextBox
            // 
            this.eMP_FNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMP_FNAME", true));
            this.eMP_FNAMETextBox.Location = new System.Drawing.Point(121, 66);
            this.eMP_FNAMETextBox.Name = "eMP_FNAMETextBox";
            this.eMP_FNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_FNAMETextBox.TabIndex = 27;
            // 
            // eMP_LNAMELabel
            // 
            eMP_LNAMELabel.AutoSize = true;
            eMP_LNAMELabel.Location = new System.Drawing.Point(12, 95);
            eMP_LNAMELabel.Name = "eMP_LNAMELabel";
            eMP_LNAMELabel.Size = new System.Drawing.Size(73, 13);
            eMP_LNAMELabel.TabIndex = 28;
            eMP_LNAMELabel.Text = "EMP LNAME:";
            // 
            // eMP_LNAMETextBox
            // 
            this.eMP_LNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "EMP_LNAME", true));
            this.eMP_LNAMETextBox.Location = new System.Drawing.Point(121, 92);
            this.eMP_LNAMETextBox.Name = "eMP_LNAMETextBox";
            this.eMP_LNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_LNAMETextBox.TabIndex = 29;
            // 
            // cONTACTLabel
            // 
            cONTACTLabel.AutoSize = true;
            cONTACTLabel.Location = new System.Drawing.Point(12, 121);
            cONTACTLabel.Name = "cONTACTLabel";
            cONTACTLabel.Size = new System.Drawing.Size(61, 13);
            cONTACTLabel.TabIndex = 30;
            cONTACTLabel.Text = "CONTACT:";
            // 
            // cONTACTTextBox
            // 
            this.cONTACTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "CONTACT", true));
            this.cONTACTTextBox.Location = new System.Drawing.Point(121, 118);
            this.cONTACTTextBox.Name = "cONTACTTextBox";
            this.cONTACTTextBox.Size = new System.Drawing.Size(100, 20);
            this.cONTACTTextBox.TabIndex = 31;
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(12, 147);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(62, 13);
            aDDRESSLabel.TabIndex = 32;
            aDDRESSLabel.Text = "ADDRESS:";
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(121, 144);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(100, 20);
            this.aDDRESSTextBox.TabIndex = 33;
            // 
            // sEXLabel
            // 
            sEXLabel.AutoSize = true;
            sEXLabel.Location = new System.Drawing.Point(12, 173);
            sEXLabel.Name = "sEXLabel";
            sEXLabel.Size = new System.Drawing.Size(31, 13);
            sEXLabel.TabIndex = 34;
            sEXLabel.Text = "SEX:";
            // 
            // sEXTextBox
            // 
            this.sEXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "SEX", true));
            this.sEXTextBox.Location = new System.Drawing.Point(121, 170);
            this.sEXTextBox.Name = "sEXTextBox";
            this.sEXTextBox.Size = new System.Drawing.Size(100, 20);
            this.sEXTextBox.TabIndex = 35;
            // 
            // mERITAL_STATUSLabel
            // 
            mERITAL_STATUSLabel.AutoSize = true;
            mERITAL_STATUSLabel.Location = new System.Drawing.Point(12, 199);
            mERITAL_STATUSLabel.Name = "mERITAL_STATUSLabel";
            mERITAL_STATUSLabel.Size = new System.Drawing.Size(103, 13);
            mERITAL_STATUSLabel.TabIndex = 36;
            mERITAL_STATUSLabel.Text = "MERITAL STATUS:";
            // 
            // mERITAL_STATUSTextBox
            // 
            this.mERITAL_STATUSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "MERITAL_STATUS", true));
            this.mERITAL_STATUSTextBox.Location = new System.Drawing.Point(121, 196);
            this.mERITAL_STATUSTextBox.Name = "mERITAL_STATUSTextBox";
            this.mERITAL_STATUSTextBox.Size = new System.Drawing.Size(100, 20);
            this.mERITAL_STATUSTextBox.TabIndex = 37;
            // 
            // pOSITIONLabel
            // 
            pOSITIONLabel.AutoSize = true;
            pOSITIONLabel.Location = new System.Drawing.Point(12, 225);
            pOSITIONLabel.Name = "pOSITIONLabel";
            pOSITIONLabel.Size = new System.Drawing.Size(61, 13);
            pOSITIONLabel.TabIndex = 38;
            pOSITIONLabel.Text = "POSITION:";
            // 
            // pOSITIONTextBox
            // 
            this.pOSITIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "POSITION", true));
            this.pOSITIONTextBox.Location = new System.Drawing.Point(121, 222);
            this.pOSITIONTextBox.Name = "pOSITIONTextBox";
            this.pOSITIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.pOSITIONTextBox.TabIndex = 39;
            // 
            // bASIC_SALARYLabel
            // 
            bASIC_SALARYLabel.AutoSize = true;
            bASIC_SALARYLabel.Location = new System.Drawing.Point(12, 251);
            bASIC_SALARYLabel.Name = "bASIC_SALARYLabel";
            bASIC_SALARYLabel.Size = new System.Drawing.Size(86, 13);
            bASIC_SALARYLabel.TabIndex = 40;
            bASIC_SALARYLabel.Text = "BASIC SALARY:";
            // 
            // bASIC_SALARYTextBox
            // 
            this.bASIC_SALARYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "BASIC_SALARY", true));
            this.bASIC_SALARYTextBox.Location = new System.Drawing.Point(121, 248);
            this.bASIC_SALARYTextBox.Name = "bASIC_SALARYTextBox";
            this.bASIC_SALARYTextBox.Size = new System.Drawing.Size(100, 20);
            this.bASIC_SALARYTextBox.TabIndex = 41;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(12, 277);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 42;
            dOBLabel.Text = "DOB:";
            // 
            // dOBTextBox
            // 
            this.dOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "DOB", true));
            this.dOBTextBox.Location = new System.Drawing.Point(121, 274);
            this.dOBTextBox.Name = "dOBTextBox";
            this.dOBTextBox.Size = new System.Drawing.Size(100, 20);
            this.dOBTextBox.TabIndex = 43;
            // 
            // uSER_IDLabel
            // 
            uSER_IDLabel.AutoSize = true;
            uSER_IDLabel.Location = new System.Drawing.Point(12, 303);
            uSER_IDLabel.Name = "uSER_IDLabel";
            uSER_IDLabel.Size = new System.Drawing.Size(54, 13);
            uSER_IDLabel.TabIndex = 44;
            uSER_IDLabel.Text = "USER ID:";
            // 
            // uSER_IDTextBox
            // 
            this.uSER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "USER_ID", true));
            this.uSER_IDTextBox.Location = new System.Drawing.Point(121, 300);
            this.uSER_IDTextBox.Name = "uSER_IDTextBox";
            this.uSER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.uSER_IDTextBox.TabIndex = 45;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(eMP_IDLabel);
            this.Controls.Add(this.eMP_IDTextBox);
            this.Controls.Add(eMP_FNAMELabel);
            this.Controls.Add(this.eMP_FNAMETextBox);
            this.Controls.Add(eMP_LNAMELabel);
            this.Controls.Add(this.eMP_LNAMETextBox);
            this.Controls.Add(cONTACTLabel);
            this.Controls.Add(this.cONTACTTextBox);
            this.Controls.Add(aDDRESSLabel);
            this.Controls.Add(this.aDDRESSTextBox);
            this.Controls.Add(sEXLabel);
            this.Controls.Add(this.sEXTextBox);
            this.Controls.Add(mERITAL_STATUSLabel);
            this.Controls.Add(this.mERITAL_STATUSTextBox);
            this.Controls.Add(pOSITIONLabel);
            this.Controls.Add(this.pOSITIONTextBox);
            this.Controls.Add(bASIC_SALARYLabel);
            this.Controls.Add(this.bASIC_SALARYTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBTextBox);
            this.Controls.Add(uSER_IDLabel);
            this.Controls.Add(this.uSER_IDTextBox);
            this.Controls.Add(this.eMPLOYEEDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eMPLOYEEBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Edit Employee Details";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).EndInit();
            this.eMPLOYEEBindingNavigator.ResumeLayout(false);
            this.eMPLOYEEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRestaurantDataSet1 myRestaurantDataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private MyRestaurantDataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private MyRestaurantDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLOYEEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eMPLOYEEBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox eMP_IDTextBox;
        private System.Windows.Forms.TextBox eMP_FNAMETextBox;
        private System.Windows.Forms.TextBox eMP_LNAMETextBox;
        private System.Windows.Forms.TextBox cONTACTTextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox sEXTextBox;
        private System.Windows.Forms.TextBox mERITAL_STATUSTextBox;
        private System.Windows.Forms.TextBox pOSITIONTextBox;
        private System.Windows.Forms.TextBox bASIC_SALARYTextBox;
        private System.Windows.Forms.TextBox dOBTextBox;
        private System.Windows.Forms.TextBox uSER_IDTextBox;
    }
}