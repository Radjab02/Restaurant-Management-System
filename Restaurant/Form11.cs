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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void oRDERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.myRestaurantDataSet1.ORDER);
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.myRestaurantDataSet1.ORDER);

        }

        private void oRDERBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }
    }
}
