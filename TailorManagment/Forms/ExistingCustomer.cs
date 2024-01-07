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
    public partial class ExistingCustomer : Form
    {
        Thread th;
        public ExistingCustomer()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
