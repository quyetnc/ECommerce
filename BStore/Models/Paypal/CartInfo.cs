using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models.Paypal
{
    public class CartInfo
    {
        public int account_id { get; set; }
        public string address { get; set; }
        public int city { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string note { get; set; }
        public string tel { get; set; }
    }
}
