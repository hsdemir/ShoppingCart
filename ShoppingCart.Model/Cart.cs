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
        public List<Product> ProductList { get; set; }
        public List<Campaign> ValidCampaigns { get; set; }
        public Coupon Coupon { get; set; }
        public double Quantity { get; set; }
        public double DiscountQuantity { get; set; }
    }
}
