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
using static Guna.UI2.Native.WinApi;

namespace TailorManagment.Forms
{
    public partial class SizeForm1 : UserControl
    {
        Customer customer=new Customer();
        BEL.Size size=new BEL.Size();
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
            size.sizeId=customer.CustomerId;
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




        }
    }
}
