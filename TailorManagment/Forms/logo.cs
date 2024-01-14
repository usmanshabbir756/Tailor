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
    public partial class logo : Form
    {
        System.Media.SoundPlayer player;
        Timer MyTimer;
        public logo()
        {
            InitializeComponent();
        }

        private void logo_Load(object sender, EventArgs e)
        {
            mainlogo.Image = new Bitmap(@"Files\mainlogo.gif");
            player = new System.Media.SoundPlayer(@"Files\intro.wav");
            player.Play();
            MyTimer = new Timer();
                MyTimer.Interval = 3000;
                MyTimer.Tick += new EventHandler(MyTimer_Tick);
                MyTimer.Start();
        }

            private void MyTimer_Tick(object sender, EventArgs e)
            {
                MyTimer.Stop();
                this.Hide();
                player.Stop();
                Form1 frm_Start = new Form1();
                frm_Start.ShowDialog();
                this.Close();
           
        }

        }
}
