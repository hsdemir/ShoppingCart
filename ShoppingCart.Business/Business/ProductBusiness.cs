using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Business
{
    public class ProductBusiness : IProductBusiness
    {
        public static string _test;
        public ProductBusiness()
        {
            _test = "test_val_1";
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
