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
    public partial class Form1 : Form
    {
        Form f2, f3, f4, f5, f6,f7,f8,f10,f11,f12,f13;
        public Form1()
        {
            InitializeComponent();
        }

        private void newDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else
                f2.Activate();
        }

        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;  
            //throw new NotImplementedException();
        }

       

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += new FormClosedEventHandler(f3_FormClosed);
                f3.Show();
            }
            else
                f3.Activate();
        }

        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
            //throw new NotImplementedException();
        }

        private void dishDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f4 == null)
            {
                f4 = new Form4();
                f4.MdiParent = this;
                f4.FormClosed += new FormClosedEventHandler(f4_FormClosed);
                f4.Show();
            }
            else
                f4.Activate();
        }

        void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f4 = null; 
            // throw new NotImplementedException();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f5 == null)
            {
                f5 = new Form5();
                f5.MdiParent = this;
                f5.FormClosed += new FormClosedEventHandler(f5_FormClosed);
                f5.Show();
            }
        }

        void f5_FormClosed(object sender, FormClosedEventArgs e)
        {
            f5 = null; 
            // throw new NotImplementedException();
        }

        private void dishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f6 == null)
            {
                f6 = new Form6();
                f6.MdiParent = this;
                f6.FormClosed += new FormClosedEventHandler(f6_FormClosed);
                f6.Show();
            }
            else
                f6.Activate();
        }

        void f6_FormClosed(object sender, FormClosedEventArgs e)
        {
            f6 = null;
            //throw new NotImplementedException();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f7==null)
            {
                f7 = new Form7();
                f7.MdiParent = this;
                f7.FormClosed += new FormClosedEventHandler(f7_FormClosed);
                f7.Show();
            }
        }

        void f7_FormClosed(object sender, FormClosedEventArgs e)
        {
            f7 = null; 
            // throw new NotImplementedException();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f8 == null)
            {
                f8 = new Form8();
                f8.MdiParent = this;
                f8.FormClosed += new FormClosedEventHandler(f8_FormClosed);
                f8.Show();
            }
        }

        void f8_FormClosed(object sender, FormClosedEventArgs e)
        {
            f8 = null; 
            // throw new NotImplementedException();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f11 == null)
            {
                f11 = new Form11();
                f11.MdiParent = this;
                f11.FormClosed += new FormClosedEventHandler(f11_FormClosed);
                f11.Show();
            }
            f11.Activate();
        }

        void f11_FormClosed(object sender, FormClosedEventArgs e)
        {
            f11 = null; 
            //throw new NotImplementedException();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f10 == null)
            {
                f10 = new Form10();
                f10.MdiParent = this;
                f10.FormClosed += new FormClosedEventHandler(f10_FormClosed);
                f10.Show();
            }
            else
                f10.Activate();

        }
        void f10_FormClosed(object sender, FormClosedEventArgs e)
        {
            f10 = null; // throw new NotImplementedException();
        }

        private void dISHODERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f12 == null)
            {
                f12 = new Form12();
                f12.MdiParent = this;
                f12.FormClosed += new FormClosedEventHandler(f12_FormClosed);
                f12.Show();
            }
            else
                f12.Activate();
        }

        void f12_FormClosed(object sender, FormClosedEventArgs e)
        {
            f12 = null; //throw new NotImplementedException();
        }

        private void makeAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateADailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f13 == null)
            {
                f13 = new Form13();
                f13.MdiParent = this;
                f13.FormClosed += new FormClosedEventHandler(f13_FormClosed);
                f13.Show();
            }
            else
                f13.Activate();
        }

        void f13_FormClosed(object sender, FormClosedEventArgs e)
        {
            f13 = null;//throw new NotImplementedException();
        }
    }
}
