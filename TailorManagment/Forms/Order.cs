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

namespace TailorManagment.Forms
{
    public partial class Order : Form
    {
        Thread th;
        public Order()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public static void openMenu()
        {
            System.Windows.Forms.Application.Run(new Menu());
        }
    }
}
