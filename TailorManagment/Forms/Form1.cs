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

namespace TailorManagment
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authenticate();
        }

        private void authenticate()
        {
            if (txtusername.Text == "UsmanShabbir" && txtpassword.Text == "Usman")
            {
                this.Close();
                th = new Thread(openMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (txtusername.Text == "UsmanShabbir")
            {
                loginerror.Text = "Enter Wrong Password";
            }
            else if (txtpassword.Text == "Usman")
            {
                loginerror.Text = "Enter Wrong User Name";
            }
            else
            {
                loginerror.Text = "Enter Wrong User Name and Password";
            }
        }
        private void openMenu()
        {
            Application.Run(new Forms.Menu());
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                authenticate();
            }
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                authenticate();
            }
        }
    }
}
