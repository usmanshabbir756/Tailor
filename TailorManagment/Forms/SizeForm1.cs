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
    public partial class SizeForm1 : UserControl
    {
        Customer customer=new Customer();
        BEL.Size size=new BEL.Size();
        SizeOperations sizeOperations=new SizeOperations();
        DataTable dt= new DataTable();

        public SizeForm1(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        

        private void SizeForm1_Load(object sender, EventArgs e)
        {
            txtid.Text = customer.CustomerId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size.customerId = customer.CustomerId;
            size.roundarms = txtroundarms.Text;
            size.roundneck = txtrundneck.Text;
            size.Skirtlength=txtskirtlength.Text;
            size.dresslength=txtdresslength.Text;
            size.Halflenght=txthalflength.Text;
            size.trouserlength=txtrouserlength.Text;
            size.shoulder=txtshoulder.Text;
            size.Thigh=txtthigh.Text;
            size.sleeves=txtsleeves.Text;
            size.Underbust=txtunderbust.Text;
            size.Waist=txtwaist.Text;
            size.wrist=txtwrist.Text;

            int a=sizeOperations.inserCustomerSize(size);
            if(a>0)
            {
                MessageBox.Show("added size");
                
                NewOrder1 nc=new NewOrder1(size.customerId);
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not added size");
                SizeForm1 nc = new SizeForm1(customer);
                this.Controls.Clear();
                this.Controls.Add(nc);
            }

        }
    }
}
