using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using ShoppingCart.Data;

namespace ShoppingCart.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        public static string _test;
        public CategoryBusiness()
        {
            _test = "test_val_1";
        }
        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
