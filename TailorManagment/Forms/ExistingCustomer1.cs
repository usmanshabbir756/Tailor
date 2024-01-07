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

namespace TailorManagment.Forms
{
    public partial class ExistingCustomer1 : UserControl
    {
        DataTable dt=new DataTable();
        Operations or = new Operations();
        public ExistingCustomer1()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            int CustomerId=int.Parse(txtid.Text);
            dt = or.GetIdByID(CustomerId);

            txtid.Text = dt.Rows[0][0].ToString();
            txtname.Text = dt.Rows[0][1].ToString();
            txtphoneno.Text = dt.Rows[0][2].ToString();
            txtemail.Text = dt.Rows[0][3].ToString();


        }
    }
}
