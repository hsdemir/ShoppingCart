using ShoppingCart.Model;
using System.Collections.Generic;

namespace ShoppingCart.Data.Interface
{
    public interface IProductData : IBaseData<Product>
    {
        List<Product> GetByCategoryId(int categoryId);
    }
}
