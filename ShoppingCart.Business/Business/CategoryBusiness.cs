using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using ShoppingCart.Data;
using ShoppingCart.Data.Interface;

namespace ShoppingCart.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private ICategoryData _categoryData;
        public CategoryBusiness(ICategoryData categoryData)
        {
            _categoryData = categoryData;
        }

        public List<Category> GetList()
        {
            return _categoryData.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryData.GetById(id);
        }

        public List<Category> GetByParentId(int categoryId)
        {
            return _categoryData.GetByParentId(categoryId);
        }

        public Category GetByTitle(string title)
        {
            return _categoryData.GetByTitle(title);
        }
    }
}
