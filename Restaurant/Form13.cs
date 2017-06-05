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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, DateTime.Parse(textBox1.Text));
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1,DateTime.Parse(textBox1.Text));
           
        }
        
    }
}
