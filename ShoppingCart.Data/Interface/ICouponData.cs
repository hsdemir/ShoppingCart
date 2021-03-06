﻿using ShoppingCart.Model;

namespace ShoppingCart.Data.Interface
{
    public interface ICouponData : IBaseData<Coupon>
    {
        Coupon GetByCode(string code);
    }
}
