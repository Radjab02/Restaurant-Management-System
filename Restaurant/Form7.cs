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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.myRestaurantDataSet1.EMPLOYEE);

        }
    }
}
