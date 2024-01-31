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
    public partial class NewOrder1 : UserControl
    {
        OrderOperations or=new OrderOperations();
        Order order=new Order();
        int customerId = 0;
        public NewOrder1()
        {
            InitializeComponent();
        }
        public NewOrder1(int id)
        {
            customerId = id;
            txtcustomerid.Text = customerId.ToString();
            InitializeComponent();
        }
       

        private void NewOrder1_Load(object sender, EventArgs e)
        {
            if(customerId > 0)
            {
                txtcustomerid.Text = customerId.ToString();
            }
            
        }




        private void guna2Button3_Click(object sender, EventArgs e)
        {
            order.customerid = int.Parse(txtcustomerid.Text);
            order.category = txtcategory.Text;
            order.orderdate = txtorderdate.Value;
            order.delieverydate = txtdeliverydate.Value;
            order.fullpayment = decimal.Parse(txtfullpayment.Text);
            order.advancepayment = decimal.Parse(txtadvancepayment.Text);
            order.pendingpayment = decimal.Parse(txtpendingpayment.Text);

            int row = or.inserCustomerOrder(order);
            if (row > 0)
            {
                MessageBox.Show("added order");

                NewCustomer1 nc = new NewCustomer1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not added order");
                NewOrder1 nc = new NewOrder1(customerId);
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
        }


        private void PendingPayment()
        {
            decimal fullpayment = 0; decimal advancepayment = 0;
            if (txtfullpayment.Text.Length > 0)
            {
                fullpayment = decimal.Parse(txtfullpayment.Text);
            }
            if (txtadvancepayment.Text.Length > 0)
            {
                advancepayment = decimal.Parse(txtadvancepayment.Text);
            }



            txtpendingpayment.Text = (fullpayment - advancepayment).ToString();
        }

        private void txtfullpayment_TextChanged(object sender, EventArgs e)
        {
            PendingPayment();
        }

        private void txtadvancepayment_TextChanged(object sender, EventArgs e)
        {
            PendingPayment();
        }
    }
}
