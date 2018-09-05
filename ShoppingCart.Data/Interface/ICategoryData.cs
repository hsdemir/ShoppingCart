using ShoppingCart.Model;
using System.Collections.Generic;

namespace ShoppingCart.Data.Interface
{
    public interface ICategoryData : IBaseData<Category>
    {
        List<Category> GetByParentId(int categoryId);
    }
}
