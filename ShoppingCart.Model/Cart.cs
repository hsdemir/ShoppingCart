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
        List<Product> ProductList { get; set; }
        List<Campaign> CampaignList { get; set; }
        public Coupon Coupon { get; set; }
        public decimal Quantity { get; set; }
    }
}
