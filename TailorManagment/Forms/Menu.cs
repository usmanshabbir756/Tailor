using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TailorManagment.Forms
{
    public partial class Menu : Form
    {
        Thread th;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formChange(this, new CustomerForm());

        }
        private void excustomer(object sender, EventArgs e)
        {
            new formChange(this, new ExistingCustomer());
        }
        private void Neworder(object sender, EventArgs e)
        {
            new formChange(this, new NewOrder());
        }
        private void Record(object sender, EventArgs e)
        {
            new formChange(this, new Record());
        }
            private void SizeUpdate(object sender, EventArgs e)
        {
            new formChange(this, new SizeUpdate());
        }
        private void Order(object sender, EventArgs e)
        {
            new formChange(this, new Order());
        }
       
    }
}
