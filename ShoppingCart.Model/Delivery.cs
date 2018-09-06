using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Delivery
    {
        public int NumberOfProducts { get; set; }
        public int NumberOfDeliveries { get; set; }
        public double TotalCost { get; set; }
    }
}
