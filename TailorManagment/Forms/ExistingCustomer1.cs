using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
using static Guna.UI2.Native.WinApi;

namespace TailorManagment.Forms
{
    public partial class ExistingCustomer1 : UserControl
    {
        DataTable dt=new DataTable();
        Operations or = new Operations();
        Customer customer = new Customer();
        public ExistingCustomer1()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            txtname.Text = null;
            txtphoneno.Text = null;
            txtemail.Text = null;
            int integer;
            Int32.TryParse(txtid.Text, out integer);
            int CustomerId=integer;
            dt = or.GetIdByID(CustomerId);
            if (dt.Rows.Count > 0)
            {
                txtid.Text = dt.Rows[0][0].ToString();
                txtname.Text = dt.Rows[0][1].ToString();
                txtphoneno.Text = dt.Rows[0][2].ToString();
                txtemail.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("Not Found");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer.CustomerId= int.Parse(txtid.Text);
            customer.name= txtname.Text;
            customer.phoneNumber= txtphoneno.Text;
            customer.email= txtemail.Text;

            int row = or.updateCustomer(customer);
            if (row > 0)
            {
                MessageBox.Show("Updated");

                ExistingCustomer1 nc = new ExistingCustomer1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not Updated");
                ExistingCustomer1 nc = new ExistingCustomer1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer.CustomerId = int.Parse(txtid.Text);
            

            int row = or.deleteCustomer(customer);

            if (row > 0)
            {
                MessageBox.Show("Deleted");

                ExistingCustomer1 nc = new ExistingCustomer1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not Deleted");
                ExistingCustomer1 nc = new ExistingCustomer1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
        }
    }
}
