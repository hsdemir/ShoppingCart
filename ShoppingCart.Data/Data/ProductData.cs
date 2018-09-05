using ShoppingCart.Data.Interface;
using ShoppingCart.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShoppingCart.Data
{
    public class ProductData : IProductData
    {
        //Database
        private readonly List<Product> _productList = new List<Product> {
            new Product { Id = 1, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 2, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 3, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 4, Title = "Mavi Kol Saati", Price = 210 },
            new Product { Id = 5, Title = "Mavi Kol Saati", Price = 210 }
        };

        public List<Product> GetList()
        {
            return _productList;
        }

        public Product GetById(int id)
        {
            return _productList.FirstOrDefault(x => x.Id == id);
        }

        public Product GetByTitle(string title)
        {
            return _productList.FirstOrDefault(x => x.Title == title);
        }
    }
}
