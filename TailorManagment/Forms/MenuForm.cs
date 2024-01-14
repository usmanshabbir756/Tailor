using Guna.UI2.WinForms;
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
        System.Media.SoundPlayer player;
        public MenuForm()
        {
            
            InitializeComponent();
            colorChanger(guna2Button1);
            NewCustomer1 nc = new NewCustomer1();
            addUserControl(nc);
        }

        private void colorChanger(Guna2Button guna)
        {
            guna2Button1.ForeColor = Color.FromArgb(22, 72, 99);
            guna2Button2.ForeColor = Color.FromArgb(22, 72, 99);
            guna2Button3.ForeColor = Color.FromArgb(22, 72, 99);
            guna2Button4.ForeColor = Color.FromArgb(22, 72, 99);
            guna2Button5.ForeColor = Color.FromArgb(22, 72, 99);
            guna2Button6.ForeColor = Color.FromArgb(22, 72, 99);

            guna.ForeColor = Color.FromArgb(234, 147, 19);
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
            colorChanger(guna2Button1);
            NewCustomer1 nc = new NewCustomer1();
            addUserControl(nc);
        }

       

        private void ExistingCustomer(object sender, EventArgs e)
        {
            colorChanger(guna2Button2);
            ExistingCustomer1 nc = new ExistingCustomer1(); 
            addUserControl(nc);
        }

        private void SizeUpdate(object sender, EventArgs e)
        {
            colorChanger(guna2Button3);
            SizeUpdate1 nc= new SizeUpdate1();
            addUserControl(nc);
        }

        private void neworder(object sender, EventArgs e)
        {
            colorChanger(guna2Button4);
            NewOrder1 nc = new NewOrder1();
            addUserControl(nc);
        }

        private void order(object sender, EventArgs e)
        {
            colorChanger(guna2Button5);
            Order1 nc = new Order1();
            addUserControl(nc);
        }

        private void Record(object sender, EventArgs e)
        {
            colorChanger(guna2Button6);
            Record1 nc = new Record1();
            addUserControl(nc);
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void guna2Button7_MouseHover(object sender, EventArgs e)
        {
            guna2Button7.ForeColor = Color.FromArgb(234, 147, 19);
        }

        private void guna2Button7_MouseLeave(object sender, EventArgs e)
        {
            guna2Button7.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 nc = new Form1();
            nc.ShowDialog();
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer(@"Files\welcome.wav");
            player.Play();
            panelContainer.BackgroundImage = new Bitmap(@"Files\Asset3.png");
            logobox.Image = new Bitmap(@"Files\tmslogo.png");
        }
    }
}
