namespace Restaurant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISHODERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateADailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.makeAnOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDishToolStripMenuItem,
            this.newEmployeeToolStripMenuItem,
            this.newOrderToolStripMenuItem,
            this.dISHODERToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newDishToolStripMenuItem
            // 
            this.newDishToolStripMenuItem.Name = "newDishToolStripMenuItem";
            this.newDishToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newDishToolStripMenuItem.Text = "New Dish";
            this.newDishToolStripMenuItem.Click += new System.EventHandler(this.newDishToolStripMenuItem_Click);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // dISHODERToolStripMenuItem
            // 
            this.dISHODERToolStripMenuItem.Name = "dISHODERToolStripMenuItem";
            this.dISHODERToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dISHODERToolStripMenuItem.Text = "DISH_ODER";
            this.dISHODERToolStripMenuItem.Click += new System.EventHandler(this.dISHODERToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishDetailsToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateToolStripMenuItem.Text = "Update & Remove";
            // 
            // dishDetailsToolStripMenuItem
            // 
            this.dishDetailsToolStripMenuItem.Name = "dishDetailsToolStripMenuItem";
            this.dishDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dishDetailsToolStripMenuItem.Text = "Dish Details";
            this.dishDetailsToolStripMenuItem.Click += new System.EventHandler(this.dishDetailsToolStripMenuItem_Click);
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishesToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dishesToolStripMenuItem
            // 
            this.dishesToolStripMenuItem.Name = "dishesToolStripMenuItem";
            this.dishesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dishesToolStripMenuItem.Text = "Dishes";
            this.dishesToolStripMenuItem.Click += new System.EventHandler(this.dishesToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // makeAnOrderToolStripMenuItem
            // 
            this.makeAnOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.generateADailyReportToolStripMenuItem});
            this.makeAnOrderToolStripMenuItem.Name = "makeAnOrderToolStripMenuItem";
            this.makeAnOrderToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.makeAnOrderToolStripMenuItem.Text = "Billing ";
            this.makeAnOrderToolStripMenuItem.Click += new System.EventHandler(this.makeAnOrderToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.orderToolStripMenuItem.Text = "Generate Receit";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::Restaurant.Properties.Resources.restaurant;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 0);
            this.panel1.TabIndex = 5;
            // 
            // generateADailyReportToolStripMenuItem
            // 
            this.generateADailyReportToolStripMenuItem.Name = "generateADailyReportToolStripMenuItem";
            this.generateADailyReportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.generateADailyReportToolStripMenuItem.Text = "Generate a daily report ";
            this.generateADailyReportToolStripMenuItem.Click += new System.EventHandler(this.generateADailyReportToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Restaurant.Properties.Resources.restaurant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WELCOME TO KANI, LIM, RAJ AND IMRAN RESTAURANT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAnOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISHODERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateADailyReportToolStripMenuItem;

    }
}