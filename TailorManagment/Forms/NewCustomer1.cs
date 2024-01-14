using BEL;
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
using System.Threading;

namespace TailorManagment.Forms
{
    public partial class NewCustomer1 : UserControl
    {
        Operations opr = new Operations();
        DataTable dt = new DataTable();
        Customer customer = new Customer();
        public NewCustomer1()
        {
            InitializeComponent();
        }
        
        private void addCustomer_Click(object sender, EventArgs e)
        {
            addCustomerDb();
        }
        private void addCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            addCustomerDb();
        }
        private void addCustomerDb()
        {
            try
            {

                customer.name = txtname.Text;
                customer.phoneNumber = txtphoneno.Text;
                customer.email = txtemail.Text;
                int row = opr.inserCustomer(customer);
                if (row > 0)
                {
                    MessageBox.Show("Added");
                    dt = opr.GetIdByNamePhoneNo(customer);
                    customer.CustomerId = Int32.Parse(dt.Rows[0][0].ToString());
                    SizeForm1 nc = new SizeForm1(customer);
                    this.Controls.Clear();
                    this.Controls.Add(nc);
                }
                else
                {
                    MessageBox.Show("Not Added");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtemail.Focus();
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtphoneno.Focus();
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                addCustomerDb();
            }
        }
    }
}
