using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Interface
{
    public interface ICartBusiness
    {
        Cart AddProduct(Cart cart, Product product, int Quantity);
        Cart ApplyCampaigns(Cart cart);
        Cart ApplyCoupon(Cart cart, string couponCode);
    }
}
