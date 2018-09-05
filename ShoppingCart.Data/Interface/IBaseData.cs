using System.Collections.Generic;

namespace ShoppingCart.Data.Interface
{
    public interface IBaseData<T> where T : class, new()
    {
        List<T> GetList();
        T GetById(int id);
        T GetByTitle(string title);
    }
}
