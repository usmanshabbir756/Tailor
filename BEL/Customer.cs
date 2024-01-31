using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    //to carry all data related to customer
    public class Customer
    {
        public int CustomerId { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }

        public string email { get; set; }
    }
}
