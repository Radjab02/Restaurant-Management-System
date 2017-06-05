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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void eMPLOYEEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.myRestaurantDataSet1.EMPLOYEE);

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.eMPLOYEEBindingSource.AddNew();
        }

        private void Save_bttn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);
        }
    }
}
