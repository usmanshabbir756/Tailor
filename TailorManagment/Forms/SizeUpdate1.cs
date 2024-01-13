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
    public partial class SizeUpdate1 : UserControl
    {
        SizeOperations sc = new SizeOperations();
        DataTable dt = new DataTable();
       BEL.Size size = new BEL.Size();
        public SizeUpdate1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Text = null;
            
            int integer;
            Int32.TryParse(txtidsearch.Text, out integer);
            int CustomerId = integer;
            dt = sc.GetIdByID(CustomerId);
            if (dt.Rows.Count > 0)
            {
                
                txtid.Text = dt.Rows[0][1].ToString();
                txtshoulder.Text = dt.Rows[0][2].ToString();
                txtwaist.Text = dt.Rows[0][3].ToString();
                txtthigh.Text = dt.Rows[0][4].ToString();
                txthalf.Text = dt.Rows[0][5].ToString();
                txtunder.Text = dt.Rows[0][6].ToString();
                txtshirtlength.Text = dt.Rows[0][8].ToString();
                txttrouser.Text = dt.Rows[0][9].ToString();
                txtdresslength.Text = dt.Rows[0][10].ToString();
                txtsleeves.Text = dt.Rows[0][11].ToString();
                txtroundarms.Text = dt.Rows[0][12].ToString();
                txtroundneck.Text = dt.Rows[0][13].ToString();
                txtwrist.Text = dt.Rows[0][14].ToString();
                MessageBox.Show("found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size.customerId =int.Parse(txtid.Text);
            size.shoulder = txtshoulder.Text;
            size.roundarms = txtroundarms.Text;
            size.roundneck = txtroundneck.Text;
            size.Skirtlength = txtshirtlength.Text;
            size.dresslength = txtdresslength.Text;
            size.sleeves = txtsleeves.Text;
            size.wrist = txtwrist.Text;
            size.Underbust = txtunder.Text;
            size.Waist = txtwaist.Text;
            size.Thigh = txtthigh.Text;
            size.Halflenght = txthalf.Text;
            size.trouserlength = txttrouser.Text;

            int row = sc.updateCustomerSize(size);
            if (row > 0)
            {
                MessageBox.Show("Updated");

                SizeUpdate1 nc = new SizeUpdate1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not Updated");
                SizeUpdate1 nc = new SizeUpdate1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            size.customerId = int.Parse(txtid.Text);


            int row = sc.deleteCustomerSize(int.Parse(txtid.Text));

            if (row > 0)
            {
                MessageBox.Show("Deleted");

                SizeUpdate1 nc = new SizeUpdate1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
            else
            {
                MessageBox.Show("not Deleted");
                SizeUpdate1 nc = new SizeUpdate1();
                this.Controls.Clear();
                this.Controls.Add(nc);
            }
        }
    }
}
