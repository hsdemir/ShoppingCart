﻿using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Interface
{
    public interface ICouponBusiness : IBaseBusiness<Coupon>
    {
        Coupon GetByCode(string code);
    }
}
