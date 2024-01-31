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
using TailorManagment.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TailorManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void authenticate()
        {
            if (txtusername.Text == "UsmanShabbir" && txtpassword.Text == "Usman")
            {
                new formChange(this, new MenuForm());
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

        private void txtusername_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                authenticate();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            authenticate();
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                authenticate();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Files\Asset4.png");
        }
    }
}
