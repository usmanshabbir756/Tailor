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
    public partial class SizeForm : Form
    {
        public Customer customer;
        public SizeForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void SizeForm_Load(object sender, EventArgs e)
        {
            txtid.Text=customer.CustomerId.ToString();
        }
    }
}
