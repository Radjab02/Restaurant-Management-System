namespace Restaurant
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.Label oRDER_IDLabel;
            System.Windows.Forms.Label tABLE_NUMLabel;
            System.Windows.Forms.Label eMP_IDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.myRestaurantDataSet1 = new Restaurant.MyRestaurantDataSet1();
            this.oRDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERTableAdapter = new Restaurant.MyRestaurantDataSet1TableAdapters.ORDERTableAdapter();
            this.tableAdapterManager = new Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager();
            this.oRDERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oRDERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oRDERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDER_IDTextBox = new System.Windows.Forms.TextBox();
            this.tABLE_NUMTextBox = new System.Windows.Forms.TextBox();
            this.eMP_IDTextBox = new System.Windows.Forms.TextBox();
            oRDER_IDLabel = new System.Windows.Forms.Label();
            tABLE_NUMLabel = new System.Windows.Forms.Label();
            eMP_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingNavigator)).BeginInit();
            this.oRDERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save Oder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myRestaurantDataSet1
            // 
            this.myRestaurantDataSet1.DataSetName = "MyRestaurantDataSet1";
            this.myRestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERBindingSource
            // 
            this.oRDERBindingSource.DataMember = "ORDER";
            this.oRDERBindingSource.DataSource = this.myRestaurantDataSet1;
            // 
            // oRDERTableAdapter
            // 
            this.oRDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DISHTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.MadeTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = this.oRDERTableAdapter;
            this.tableAdapterManager.UpdateOrder = Restaurant.MyRestaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oRDERBindingNavigator
            // 
            this.oRDERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oRDERBindingNavigator.BindingSource = this.oRDERBindingSource;
            this.oRDERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oRDERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oRDERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oRDERBindingNavigatorSaveItem});
            this.oRDERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oRDERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oRDERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oRDERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oRDERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oRDERBindingNavigator.Name = "oRDERBindingNavigator";
            this.oRDERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oRDERBindingNavigator.Size = new System.Drawing.Size(695, 25);
            this.oRDERBindingNavigator.TabIndex = 15;
            this.oRDERBindingNavigator.Text = "bindingNavigator1";
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
            // oRDERBindingNavigatorSaveItem
            // 
            this.oRDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oRDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oRDERBindingNavigatorSaveItem.Image")));
            this.oRDERBindingNavigatorSaveItem.Name = "oRDERBindingNavigatorSaveItem";
            this.oRDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oRDERBindingNavigatorSaveItem.Text = "Save Data";
            this.oRDERBindingNavigatorSaveItem.Click += new System.EventHandler(this.oRDERBindingNavigatorSaveItem_Click_1);
            // 
            // oRDERDataGridView
            // 
            this.oRDERDataGridView.AutoGenerateColumns = false;
            this.oRDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRDERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.oRDERDataGridView.DataSource = this.oRDERBindingSource;
            this.oRDERDataGridView.Location = new System.Drawing.Point(245, 38);
            this.oRDERDataGridView.Name = "oRDERDataGridView";
            this.oRDERDataGridView.Size = new System.Drawing.Size(300, 220);
            this.oRDERDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORDER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ORDER_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TABLE_NUM";
            this.dataGridViewTextBoxColumn2.HeaderText = "TABLE_NUM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EMP_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMP_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // oRDER_IDLabel
            // 
            oRDER_IDLabel.AutoSize = true;
            oRDER_IDLabel.Location = new System.Drawing.Point(12, 38);
            oRDER_IDLabel.Name = "oRDER_IDLabel";
            oRDER_IDLabel.Size = new System.Drawing.Size(63, 13);
            oRDER_IDLabel.TabIndex = 22;
            oRDER_IDLabel.Text = "ORDER ID:";
            // 
            // oRDER_IDTextBox
            // 
            this.oRDER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "ORDER_ID", true));
            this.oRDER_IDTextBox.Location = new System.Drawing.Point(90, 35);
            this.oRDER_IDTextBox.Name = "oRDER_IDTextBox";
            this.oRDER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.oRDER_IDTextBox.TabIndex = 23;
            // 
            // tABLE_NUMLabel
            // 
            tABLE_NUMLabel.AutoSize = true;
            tABLE_NUMLabel.Location = new System.Drawing.Point(12, 64);
            tABLE_NUMLabel.Name = "tABLE_NUMLabel";
            tABLE_NUMLabel.Size = new System.Drawing.Size(72, 13);
            tABLE_NUMLabel.TabIndex = 24;
            tABLE_NUMLabel.Text = "TABLE NUM:";
            // 
            // tABLE_NUMTextBox
            // 
            this.tABLE_NUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "TABLE_NUM", true));
            this.tABLE_NUMTextBox.Location = new System.Drawing.Point(90, 61);
            this.tABLE_NUMTextBox.Name = "tABLE_NUMTextBox";
            this.tABLE_NUMTextBox.Size = new System.Drawing.Size(100, 20);
            this.tABLE_NUMTextBox.TabIndex = 25;
            // 
            // eMP_IDLabel
            // 
            eMP_IDLabel.AutoSize = true;
            eMP_IDLabel.Location = new System.Drawing.Point(12, 90);
            eMP_IDLabel.Name = "eMP_IDLabel";
            eMP_IDLabel.Size = new System.Drawing.Size(47, 13);
            eMP_IDLabel.TabIndex = 26;
            eMP_IDLabel.Text = "EMP ID:";
            // 
            // eMP_IDTextBox
            // 
            this.eMP_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "EMP_ID", true));
            this.eMP_IDTextBox.Location = new System.Drawing.Point(90, 87);
            this.eMP_IDTextBox.Name = "eMP_IDTextBox";
            this.eMP_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMP_IDTextBox.TabIndex = 27;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 344);
            this.Controls.Add(oRDER_IDLabel);
            this.Controls.Add(this.oRDER_IDTextBox);
            this.Controls.Add(tABLE_NUMLabel);
            this.Controls.Add(this.tABLE_NUMTextBox);
            this.Controls.Add(eMP_IDLabel);
            this.Controls.Add(this.eMP_IDTextBox);
            this.Controls.Add(this.oRDERDataGridView);
            this.Controls.Add(this.oRDERBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Oder Details";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myRestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingNavigator)).EndInit();
            this.oRDERBindingNavigator.ResumeLayout(false);
            this.oRDERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MyRestaurantDataSet1 myRestaurantDataSet1;
        private System.Windows.Forms.BindingSource oRDERBindingSource;
        private MyRestaurantDataSet1TableAdapters.ORDERTableAdapter oRDERTableAdapter;
        private MyRestaurantDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oRDERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oRDERBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView oRDERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox oRDER_IDTextBox;
        private System.Windows.Forms.TextBox tABLE_NUMTextBox;
        private System.Windows.Forms.TextBox eMP_IDTextBox;
    }
}