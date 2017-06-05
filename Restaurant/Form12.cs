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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void madeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.madeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.Made' table. You can move, or remove it, as needed.
            this.madeTableAdapter.Fill(this.myRestaurantDataSet1.Made);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.madeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.madeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);
        }
    }
}
