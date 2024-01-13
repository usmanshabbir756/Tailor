using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorManagment.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewCustomer1 nc = new NewCustomer1();
            addUserControl(nc);
        }

        private void ExistingCustomer(object sender, EventArgs e)
        {
            ExistingCustomer1 nc = new ExistingCustomer1(); 
            addUserControl(nc);
        }

        private void SizeUpdate(object sender, EventArgs e)
        {
            SizeUpdate1 nc= new SizeUpdate1();
            addUserControl(nc);
        }

        private void neworder(object sender, EventArgs e)
        {
            NewOrder1 nc = new NewOrder1();
            addUserControl(nc);
        }

        private void order(object sender, EventArgs e)
        {
            Order1 nc = new Order1();
            addUserControl(nc);
        }

        private void Record(object sender, EventArgs e)
        {
            Record1 nc = new Record1();
            addUserControl(nc);
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
