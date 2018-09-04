using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Interface
{
    interface ICategoryData
    {
        List<Category> GetList();
        Category GetById(int id);
        Category GetByTitle(string title);
    }
}
