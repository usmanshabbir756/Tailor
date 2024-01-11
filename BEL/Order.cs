using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Order
    {
        public int customerid { get; set; }
        public int orderid { get; set; }
        public DateTime orderdate { get; set; }
        public DateTime delieverydate { get; set; }
        public int fullpayment { get; set; }
        public int advancepayment { get; set; }
        public int pendingpayment { get; set; }
        public string category { get; set; }
    }
}
