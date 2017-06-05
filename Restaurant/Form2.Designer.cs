namespace Restaurant
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label dISH_IDLabel;
            System.Windows.Forms.Label dISH_NAMELabel;
            System.Windows.Forms.Label dISH_TYPELabel;
            System.Windows.Forms.Label sELLING_PRICELabel;
            this.myRestaurantDataSet1 = new Restaurant.MyRestaurantDataSet1();
            this.dISHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dISHTableAdapter = new Restaurant.MyRestaurantDataSet1TableAdapters.DISHTableAdapter();
            this.tableAdapterManager = new Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager();
            this.dISHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dISHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.AddDish_bttn = new System.Windows.Forms.Button();
            this.SaveDish_bttn = new System.Windows.Forms.Button();
            this.dISH_IDTextBox = new System.Windows.Forms.TextBox();
            this.dISH_NAMETextBox = new System.Windows.Forms.TextBox();
            this.dISH_TYPETextBox = new System.Windows.Forms.TextBox();
            this.sELLING_PRICETextBox = new System.Windows.Forms.TextBox();
            this.dISHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dISH_IDLabel = new System.Windows.Forms.Label();
            dISH_NAMELabel = new System.Windows.Forms.Label();
            dISH_TYPELabel = new System.Windows.Forms.Label();
            sELLING_PRICELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISHBindingNavigator)).BeginInit();
            this.dISHBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dISHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myRestaurantDataSet1
            // 
            this.myRestaurantDataSet1.DataSetName = "MyRestaurantDataSet1";
            this.myRestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dISHBindingSource
            // 
            this.dISHBindingSource.DataMember = "DISH";
            this.dISHBindingSource.DataSource = this.myRestaurantDataSet1;
            // 
            // dISHTableAdapter
            // 
            this.dISHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISHTableAdapter = this.dISHTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.MadeTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dISHBindingNavigator
            // 
            this.dISHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dISHBindingNavigator.BindingSource = this.dISHBindingSource;
            this.dISHBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dISHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dISHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dISHBindingNavigatorSaveItem});
            this.dISHBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dISHBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dISHBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dISHBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dISHBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dISHBindingNavigator.Name = "dISHBindingNavigator";
            this.dISHBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dISHBindingNavigator.Size = new System.Drawing.Size(928, 25);
            this.dISHBindingNavigator.TabIndex = 0;
            this.dISHBindingNavigator.Text = "bindingNavigator1";
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
            // dISHBindingNavigatorSaveItem
            // 
            this.dISHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dISHBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dISHBindingNavigatorSaveItem.Image")));
            this.dISHBindingNavigatorSaveItem.Name = "dISHBindingNavigatorSaveItem";
            this.dISHBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dISHBindingNavigatorSaveItem.Text = "Save Data";
            this.dISHBindingNavigatorSaveItem.Click += new System.EventHandler(this.dISHBindingNavigatorSaveItem_Click);
            // 
            // AddDish_bttn
            // 
            this.AddDish_bttn.Location = new System.Drawing.Point(50, 270);
            this.AddDish_bttn.Name = "AddDish_bttn";
            this.AddDish_bttn.Size = new System.Drawing.Size(75, 23);
            this.AddDish_bttn.TabIndex = 14;
            this.AddDish_bttn.Text = "Add Dish";
            this.AddDish_bttn.UseVisualStyleBackColor = true;
            this.AddDish_bttn.Click += new System.EventHandler(this.AddDish_bttn_Click);
            // 
            // SaveDish_bttn
            // 
            this.SaveDish_bttn.Location = new System.Drawing.Point(50, 299);
            this.SaveDish_bttn.Name = "SaveDish_bttn";
            this.SaveDish_bttn.Size = new System.Drawing.Size(75, 23);
            this.SaveDish_bttn.TabIndex = 15;
            this.SaveDish_bttn.Text = "Save All";
            this.SaveDish_bttn.UseVisualStyleBackColor = true;
            this.SaveDish_bttn.Click += new System.EventHandler(this.SaveDish_bttn_Click);
            // 
            // dISH_IDLabel
            // 
            dISH_IDLabel.AutoSize = true;
            dISH_IDLabel.Location = new System.Drawing.Point(25, 63);
            dISH_IDLabel.Name = "dISH_IDLabel";
            dISH_IDLabel.Size = new System.Drawing.Size(50, 13);
            dISH_IDLabel.TabIndex = 15;
            dISH_IDLabel.Text = "DISH ID:";
            // 
            // dISH_IDTextBox
            // 
            this.dISH_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISHBindingSource, "DISH_ID", true));
            this.dISH_IDTextBox.Location = new System.Drawing.Point(121, 60);
            this.dISH_IDTextBox.Name = "dISH_IDTextBox";
            this.dISH_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dISH_IDTextBox.TabIndex = 16;
            // 
            // dISH_NAMELabel
            // 
            dISH_NAMELabel.AutoSize = true;
            dISH_NAMELabel.Location = new System.Drawing.Point(25, 89);
            dISH_NAMELabel.Name = "dISH_NAMELabel";
            dISH_NAMELabel.Size = new System.Drawing.Size(70, 13);
            dISH_NAMELabel.TabIndex = 17;
            dISH_NAMELabel.Text = "DISH NAME:";
            // 
            // dISH_NAMETextBox
            // 
            this.dISH_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISHBindingSource, "DISH_NAME", true));
            this.dISH_NAMETextBox.Location = new System.Drawing.Point(121, 86);
            this.dISH_NAMETextBox.Name = "dISH_NAMETextBox";
            this.dISH_NAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.dISH_NAMETextBox.TabIndex = 18;
            // 
            // dISH_TYPELabel
            // 
            dISH_TYPELabel.AutoSize = true;
            dISH_TYPELabel.Location = new System.Drawing.Point(25, 115);
            dISH_TYPELabel.Name = "dISH_TYPELabel";
            dISH_TYPELabel.Size = new System.Drawing.Size(67, 13);
            dISH_TYPELabel.TabIndex = 19;
            dISH_TYPELabel.Text = "DISH TYPE:";
            // 
            // dISH_TYPETextBox
            // 
            this.dISH_TYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISHBindingSource, "DISH_TYPE", true));
            this.dISH_TYPETextBox.Location = new System.Drawing.Point(121, 112);
            this.dISH_TYPETextBox.Name = "dISH_TYPETextBox";
            this.dISH_TYPETextBox.Size = new System.Drawing.Size(100, 20);
            this.dISH_TYPETextBox.TabIndex = 20;
            // 
            // sELLING_PRICELabel
            // 
            sELLING_PRICELabel.AutoSize = true;
            sELLING_PRICELabel.Location = new System.Drawing.Point(25, 141);
            sELLING_PRICELabel.Name = "sELLING_PRICELabel";
            sELLING_PRICELabel.Size = new System.Drawing.Size(90, 13);
            sELLING_PRICELabel.TabIndex = 21;
            sELLING_PRICELabel.Text = "SELLING PRICE:";
            // 
            // sELLING_PRICETextBox
            // 
            this.sELLING_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dISHBindingSource, "SELLING_PRICE", true));
            this.sELLING_PRICETextBox.Location = new System.Drawing.Point(121, 138);
            this.sELLING_PRICETextBox.Name = "sELLING_PRICETextBox";
            this.sELLING_PRICETextBox.Size = new System.Drawing.Size(100, 20);
            this.sELLING_PRICETextBox.TabIndex = 22;
            // 
            // dISHDataGridView
            // 
            this.dISHDataGridView.AutoGenerateColumns = false;
            this.dISHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dISHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dISHDataGridView.DataSource = this.dISHBindingSource;
            this.dISHDataGridView.Location = new System.Drawing.Point(247, 53);
            this.dISHDataGridView.Name = "dISHDataGridView";
            this.dISHDataGridView.Size = new System.Drawing.Size(468, 269);
            this.dISHDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DISH_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DISH_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DISH_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "DISH_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DISH_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DISH_TYPE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SELLING_PRICE";
            this.dataGridViewTextBoxColumn4.HeaderText = "SELLING_PRICE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 382);
            this.Controls.Add(this.dISHDataGridView);
            this.Controls.Add(dISH_IDLabel);
            this.Controls.Add(this.dISH_IDTextBox);
            this.Controls.Add(dISH_NAMELabel);
            this.Controls.Add(this.dISH_NAMETextBox);
            this.Controls.Add(dISH_TYPELabel);
            this.Controls.Add(this.dISH_TYPETextBox);
            this.Controls.Add(sELLING_PRICELabel);
            this.Controls.Add(this.sELLING_PRICETextBox);
            this.Controls.Add(this.SaveDish_bttn);
            this.Controls.Add(this.AddDish_bttn);
            this.Controls.Add(this.dISHBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "ADD A NEW DISH";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISHBindingNavigator)).EndInit();
            this.dISHBindingNavigator.ResumeLayout(false);
            this.dISHBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dISHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRestaurantDataSet1 myRestaurantDataSet1;
        private System.Windows.Forms.BindingSource dISHBindingSource;
        private MyRestaurantDataSet1TableAdapters.DISHTableAdapter dISHTableAdapter;
        private MyRestaurantDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dISHBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dISHBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button AddDish_bttn;
        private System.Windows.Forms.Button SaveDish_bttn;
        private System.Windows.Forms.TextBox dISH_IDTextBox;
        private System.Windows.Forms.TextBox dISH_NAMETextBox;
        private System.Windows.Forms.TextBox dISH_TYPETextBox;
        private System.Windows.Forms.TextBox sELLING_PRICETextBox;
        private System.Windows.Forms.DataGridView dISHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}