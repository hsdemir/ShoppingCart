using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Interfaces
{
   public interface IProductBusiness
    {
        List<Product> GetList();
        Product GetById();
        Product GetByTitle();
    }
}
