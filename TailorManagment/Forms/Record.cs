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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new formChange(this, new Menu());
        }
       
    }
}

