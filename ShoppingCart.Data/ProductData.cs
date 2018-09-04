using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class ProductData
    {
        public List<Product> productList = new List<Product> {
            new Product { Id = 1, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 2, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 3, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 4, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 5, Title = "Mavi Kol Saati", Price = 210 }
        };


    }
}
