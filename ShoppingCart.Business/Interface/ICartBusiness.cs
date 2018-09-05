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
        bool AddProduct(Product product, int amount);
        bool ApplyCampaigns(List<Campaign> campaignList);
        bool ApplyCoupon(Coupon coupon);
    }
}
