using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private decimal fullpayment = 0m;
        private decimal advancepayment = 0m;
        private decimal pendingpayment = 0m;
        public NewOrder1()
        {
            InitializeComponent();
        }
        public NewOrder1(int id)
        {
            InitializeComponent();
            customerId = id;
            txtcustomerid.Text = customerId.ToString();
            
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
            try
            {
                if (txtcustomerid.Text.Length > 0)
                {
                    order.customerid = int.Parse(txtcustomerid.Text);
                }
                order.category = txtcategory.Text;
                order.orderdate = txtorderdate.Value;
                order.delieverydate = txtdeliverydate.Value;
                order.fullpayment = fullpayment;
                order.advancepayment = advancepayment;
                order.pendingpayment = pendingpayment;

                int row = or.inserCustomerOrder(order);
                if (row > 0)
                {
                    MessageBox.Show("added order");
                    NewOrder1 nc = new NewOrder1();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PendingPayment()
        {
            
            if (txtfullpayment.Text.Length > 0)
            {
                decimal.TryParse(txtfullpayment.Text.ToString(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal resultTryParse);
                fullpayment = resultTryParse;
            }
            else
            {
                fullpayment = 0m;
            }
            if (txtadvancepayment.Text.Length > 1)
            {
                decimal.TryParse(txtadvancepayment.Text.ToString(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal resultTryParsea);

                advancepayment = resultTryParsea;
            }
            else
            {
                advancepayment = 0m;
                txtadvancepayment.Text = "0";
            }
            txtpendingpayment.Text = (fullpayment - advancepayment).ToString();
            decimal.TryParse(txtpendingpayment.Text.ToString(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal resultTryParseapp);
            pendingpayment = resultTryParseapp;
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
