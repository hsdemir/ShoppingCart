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
        Cart AddProduct(Cart cart, Product product);
        bool ApplyCampaigns(Cart cart, List<Campaign> campaignList);
        bool ApplyCoupon(Cart cart, Coupon coupon);
    }
}
