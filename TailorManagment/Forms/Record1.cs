using BAL;
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
    public partial class Record1 : UserControl
    {
        DataTable dt=new DataTable();
        Operations or=new Operations();
        public Record1()
        {
            InitializeComponent();
            dt=or.GetAllRecord();

        }

        private void Record1_Load(object sender, EventArgs e)
        {
            Record.DataSource = dt;
        }
    }
}
