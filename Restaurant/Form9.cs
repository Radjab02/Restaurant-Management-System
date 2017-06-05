using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe; // Here i have to use SqlCeConnection Class.
using System.IO;


namespace Restaurant
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox2.PasswordChar='x';// to hide password while typing
            textBox2.MaxLength = 10;// to limit it to ten character
        }
        Form f1;
        public static SqlCeDataAdapter sda = null;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection("Data Source="
                + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "MyRestaurant.sdf"));
         
            sda = new SqlCeDataAdapter("select count(*) from Users where UserName ='" + textBox1.Text + "' and PassWord ='"+textBox2.Text + "'",con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                f1 = new Form1();
                f1.Show();
            }
            else
                MessageBox.Show("Please check your Username and Password");
        }
    }
}
