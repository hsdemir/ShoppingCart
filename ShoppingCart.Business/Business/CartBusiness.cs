using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Business
{
    public class CartBusiness : ICartBusiness
    {
        public Cart AddProduct(Cart cart, Product product)
        {
            cart.ProductList.Add(product);
            return cart;
        }

        public bool ApplyCampaigns(Cart cart, List<Campaign> campaignList)
        {
            throw new NotImplementedException();
        }

        public bool ApplyCoupon(Cart cart, Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
