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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void oRDERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.myRestaurantDataSet1.ORDER);
            // TODO: This line of code loads data into the 'myRestaurantDataSet1.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.myRestaurantDataSet1.ORDER);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.oRDERBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.oRDERBindingSource.RemoveCurrent();
        }

        private void oRDERBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myRestaurantDataSet1);

        }
    }
}
