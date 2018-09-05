using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Business
{
    public class CartBusiness : ICartBusiness
    {
        public bool AddProduct(Product product, int amount)
        {
            throw new NotImplementedException();
        }

        public bool ApplyCampaigns(List<Campaign> campaignList)
        {
            throw new NotImplementedException();
        }

        public bool ApplyCoupon(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
