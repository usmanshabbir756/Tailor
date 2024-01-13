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
        public decimal fullpayment { get; set; }
        public decimal advancepayment { get; set; }
        public decimal pendingpayment { get; set; }
        public string category { get; set; }
    }
}
