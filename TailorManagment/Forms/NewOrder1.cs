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

namespace TailorManagment.Forms
{
    public partial class NewOrder1 : UserControl
    {
        Order order=new Order();
        Customer customer = new Customer();
        public NewOrder1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.customerid = customer.CustomerId;
            order.fullpayment=int.Parse(txtfullpayment.Text);
            order.advancepayment=int.Parse(txtadvancepayment.Text);
            order.pendingpayment=int.Parse(txtpendingpayment.Text);
            order.category = txtcategory.Text;


        }
    }
}
