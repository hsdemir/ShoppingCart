using System.Collections.Generic;

namespace ShoppingCart.Business.Interface
{
    public interface IBaseBusiness<T> where T : class, new()
    {
        List<T> GetList();
        T GetById(int id);
        T GetByTitle(string title);
    }
}
