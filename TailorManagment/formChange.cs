using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorManagment
{
    internal class formChange
    {
        Thread th;
        Form open;
        public formChange(Form c,Form o)
        {
            c.Close();
            open= o;
            th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForm()
        {
            open.ShowDialog();
        }

    }
}
