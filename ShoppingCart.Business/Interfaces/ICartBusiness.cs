using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Interfaces
{
    public interface ICartBusiness
    {
        bool AddProduct(Product product, int amount);
        bool applyCampaigns(List<Campaign> campaignList);
        bool applyCoupon(Coupon coupon);
    }
}
