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
            this.Close();
            th = new Thread(openCustomer);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCustomer()
        {
            Application.Run(new Customer());
        }



    }
}
