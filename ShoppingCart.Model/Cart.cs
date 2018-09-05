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
        public List<Campaign> CampaignList { get; set; }
        public Coupon Coupon { get; set; }
        public decimal Quantity { get; set; }
    }
}
