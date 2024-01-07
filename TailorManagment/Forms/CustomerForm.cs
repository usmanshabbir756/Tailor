using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
using System.Threading;
using TailorManagment.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TailorManagment.Forms
{
    public partial class CustomerForm : Form
    {
        Thread th;
        Operations opr = new Operations();
        DataTable dt = new DataTable();
        Customer customer = new Customer();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
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
                    new formChange(this, new SizeForm(customer));
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            new formChange(this, new Menu());
        }

    }
}

