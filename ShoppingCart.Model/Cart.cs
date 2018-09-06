using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public Campaign ValidCampaign { get; set; }
        public Coupon ValidCoupon { get; set; }
        public double Amount { get; set; }
        public double DiscountAmount { get; set; }
        public Delivery Delivery { get; set; }
    }
}
