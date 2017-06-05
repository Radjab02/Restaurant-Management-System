namespace Restaurant
{
    partial class Form12
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
            System.Windows.Forms.Label oRDER_IDLabel;
            System.Windows.Forms.Label dISH_IDLabel;
            System.Windows.Forms.Label qUANTITYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.myRestaurantDataSet1 = new Restaurant.MyRestaurantDataSet1();
            this.madeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.madeTableAdapter = new Restaurant.MyRestaurantDataSet1TableAdapters.MadeTableAdapter();
            this.tableAdapterManager = new Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager();
            this.madeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.madeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.madeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDER_IDTextBox = new System.Windows.Forms.TextBox();
            this.dISH_IDTextBox = new System.Windows.Forms.TextBox();
            this.qUANTITYTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            oRDER_IDLabel = new System.Windows.Forms.Label();
            dISH_IDLabel = new System.Windows.Forms.Label();
            qUANTITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingNavigator)).BeginInit();
            this.madeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.madeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oRDER_IDLabel
            // 
            oRDER_IDLabel.AutoSize = true;
            oRDER_IDLabel.Location = new System.Drawing.Point(36, 82);
            oRDER_IDLabel.Name = "oRDER_IDLabel";
            oRDER_IDLabel.Size = new System.Drawing.Size(63, 13);
            oRDER_IDLabel.TabIndex = 2;
            oRDER_IDLabel.Text = "ORDER ID:";
            // 
            // dISH_IDLabel
            // 
            dISH_IDLabel.AutoSize = true;
            dISH_IDLabel.Location = new System.Drawing.Point(36, 108);
            dISH_IDLabel.Name = "dISH_IDLabel";
            dISH_IDLabel.Size = new System.Drawing.Size(50, 13);
            dISH_IDLabel.TabIndex = 4;
            dISH_IDLabel.Text = "DISH ID:";
            // 
            // qUANTITYLabel
            // 
            qUANTITYLabel.AutoSize = true;
            qUANTITYLabel.Location = new System.Drawing.Point(36, 134);
            qUANTITYLabel.Name = "qUANTITYLabel";
            qUANTITYLabel.Size = new System.Drawing.Size(65, 13);
            qUANTITYLabel.TabIndex = 6;
            qUANTITYLabel.Text = "QUANTITY:";
            // 
            // myRestaurantDataSet1
            // 
            this.myRestaurantDataSet1.DataSetName = "MyRestaurantDataSet1";
            this.myRestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // madeBindingSource
            // 
            this.madeBindingSource.DataMember = "Made";
            this.madeBindingSource.DataSource = this.myRestaurantDataSet1;
            // 
            // madeTableAdapter
            // 
            this.madeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISHTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.MadeTableAdapter = this.madeTableAdapter;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // madeBindingNavigator
            // 
            this.madeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.madeBindingNavigator.BindingSource = this.madeBindingSource;
            this.madeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.madeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.madeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.madeBindingNavigatorSaveItem});
            this.madeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.madeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.madeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.madeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.madeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.madeBindingNavigator.Name = "madeBindingNavigator";
            this.madeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.madeBindingNavigator.Size = new System.Drawing.Size(628, 25);
            this.madeBindingNavigator.TabIndex = 0;
            this.madeBindingNavigator.Text = "bindingNavigator1";
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
            // madeBindingNavigatorSaveItem
            // 
            this.madeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.madeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("madeBindingNavigatorSaveItem.Image")));
            this.madeBindingNavigatorSaveItem.Name = "madeBindingNavigatorSaveItem";
            this.madeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.madeBindingNavigatorSaveItem.Text = "Save Data";
            this.madeBindingNavigatorSaveItem.Click += new System.EventHandler(this.madeBindingNavigatorSaveItem_Click);
            // 
            // madeDataGridView
            // 
            this.madeDataGridView.AutoGenerateColumns = false;
            this.madeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.madeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.madeDataGridView.DataSource = this.madeBindingSource;
            this.madeDataGridView.Location = new System.Drawing.Point(236, 65);
            this.madeDataGridView.Name = "madeDataGridView";
            this.madeDataGridView.Size = new System.Drawing.Size(351, 220);
            this.madeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORDER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ORDER_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DISH_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DISH_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTITY";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // oRDER_IDTextBox
            // 
            this.oRDER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.madeBindingSource, "ORDER_ID", true));
            this.oRDER_IDTextBox.Location = new System.Drawing.Point(107, 79);
            this.oRDER_IDTextBox.Name = "oRDER_IDTextBox";
            this.oRDER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.oRDER_IDTextBox.TabIndex = 3;
            // 
            // dISH_IDTextBox
            // 
            this.dISH_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.madeBindingSource, "DISH_ID", true));
            this.dISH_IDTextBox.Location = new System.Drawing.Point(107, 105);
            this.dISH_IDTextBox.Name = "dISH_IDTextBox";
            this.dISH_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dISH_IDTextBox.TabIndex = 5;
            // 
            // qUANTITYTextBox
            // 
            this.qUANTITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.madeBindingSource, "QUANTITY", true));
            this.qUANTITYTextBox.Location = new System.Drawing.Point(107, 131);
            this.qUANTITYTextBox.Name = "qUANTITYTextBox";
            this.qUANTITYTextBox.Size = new System.Drawing.Size(100, 20);
            this.qUANTITYTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(oRDER_IDLabel);
            this.Controls.Add(this.oRDER_IDTextBox);
            this.Controls.Add(dISH_IDLabel);
            this.Controls.Add(this.dISH_IDTextBox);
            this.Controls.Add(qUANTITYLabel);
            this.Controls.Add(this.qUANTITYTextBox);
            this.Controls.Add(this.madeDataGridView);
            this.Controls.Add(this.madeBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Composite Table between Dish and Order";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madeBindingNavigator)).EndInit();
            this.madeBindingNavigator.ResumeLayout(false);
            this.madeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.madeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRestaurantDataSet1 myRestaurantDataSet1;
        private System.Windows.Forms.BindingSource madeBindingSource;
        private MyRestaurantDataSet1TableAdapters.MadeTableAdapter madeTableAdapter;
        private MyRestaurantDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator madeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton madeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView madeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox oRDER_IDTextBox;
        private System.Windows.Forms.TextBox dISH_IDTextBox;
        private System.Windows.Forms.TextBox qUANTITYTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}