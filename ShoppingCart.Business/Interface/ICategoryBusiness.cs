using ShoppingCart.Model;
using System.Collections.Generic;

namespace ShoppingCart.Business.Interface
{
    public interface ICategoryBusiness : IBaseBusiness<Category>
    {
        List<Category> GetByParentId(int categoryId);
    }
}
