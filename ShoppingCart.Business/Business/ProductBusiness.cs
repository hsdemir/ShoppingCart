using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using ShoppingCart.Data.Interface;

namespace ShoppingCart.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private IProductData _productData;
        public ProductBusiness(IProductData productData)
        {
            _productData = productData;
        }

        public List<Product> GetList()
        {
            return _productData.GetList();
        }
        public Product GetById(int id)
        {
            return _productData.GetById(id);
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productData.GetByCategoryId(categoryId);
        }

        public Product GetByTitle(string title)
        {
            return _productData.GetByTitle(title);
        }
    }
}
