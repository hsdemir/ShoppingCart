using ShoppingCart.Data.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Data
{
    public class CouponData : ICouponData
    {
        public Coupon GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Coupon GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Coupon> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
