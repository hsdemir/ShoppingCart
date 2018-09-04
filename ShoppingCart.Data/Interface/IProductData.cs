using ShoppingCart.Model;
using System.Collections.Generic;

namespace ShoppingCart.Data.Interface
{
    public interface IProductData
    {
        List<Product> GetList();
        Product GetById(int id);
        Product GetByTitle(string title);
    }
}
