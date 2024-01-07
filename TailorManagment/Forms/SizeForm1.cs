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
    public partial class SizeForm1 : UserControl
    {
        Customer customer=new Customer();
        Size size= new Size();
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
            
        }
    }
}
