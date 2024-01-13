using BAL;
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
using System.Xml.Linq;

namespace TailorManagment.Forms
{
    public partial class Order1 : UserControl
    {
        OrderOperations or=new OrderOperations();
        DataTable dt = new DataTable();
        Order order = new Order();
        public Order1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcatagory.Text = string.Empty;
            txtorderdate.Text = string.Empty;
            txtdeliverydate.Text = string.Empty;
            txtfullpayment.Text = string.Empty;
            txtadvancepayment.Text = string.Empty;  
            txtpending.Text = string.Empty;

            
            
            int integer;
            Int32.TryParse(txtid.Text, out integer);
            int orderId = integer;
            dt = or.GetOrderIdByID(orderId);
            if (dt.Rows.Count > 0)
            {
                txtcatagory.Text = dt.Rows[0][2].ToString();
                txtorderdate.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                txtdeliverydate.Value = DateTime.Parse(dt.Rows[0][4].ToString());
                txtadvancepayment.Text = dt.Rows[0][5].ToString();
                txtpending.Text = dt.Rows[0][6].ToString();
                txtfullpayment.Text = dt.Rows[0][7].ToString();
                


            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.orderid = int.Parse(txtid.Text);
            order.category = txtcatagory.Text;
            order.orderdate =DateTime.Parse(txtorderdate.Text);
            order.delieverydate =DateTime.Parse(txtdeliverydate.Text);
            order.fullpayment =decimal.Parse(txtfullpayment.Text);
            order.advancepayment =decimal.Parse(txtadvancepayment.Text);
            order.pendingpayment =decimal.Parse(txtpending.Text);

            int row = or.updateOrder(order);
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtadvancepayment.Text = txtfullpayment.Text;
            txtpending.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtid.Text);

            int row = or.deleteOrder(id);

            if (row > 0)
            {
                MessageBox.Show("Deleted");

                Order1 nc = new Order1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not Deleted");
                Order1 nc = new Order1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }

        }
    }
}
