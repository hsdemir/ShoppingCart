using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Coupon
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double MinimumAmount { get; set; }
        public int Discount { get; set; }
    }
}
