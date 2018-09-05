using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinimumProduct { get; set; }
        public int Discount { get; set; }
        public DiscountType DiscountType { get; set; }
        public Category Category { get; set; }
    }
}
