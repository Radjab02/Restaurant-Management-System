using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dISHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dISHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.DISH' table. You can move, or remove it, as needed.
            this.dISHTableAdapter.Fill(this.myRestaurantDataSet1.DISH);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dISHBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dISHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dISHBindingSource.RemoveCurrent();
        }
    }
}
