﻿using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using ShoppingCart.Data.Interface;

namespace ShoppingCart.Business
{
    public class CouponBusiness : ICouponBusiness
    {
        private ICouponData _couponData;
        public CouponBusiness(ICouponData couponBusiness)
        {
            _couponData = couponBusiness;
        }

        public List<Coupon> GetList()
        {
            return _couponData.GetList();
        }

        public Coupon GetById(int id)
        {
            return _couponData.GetById(id);
        }

        public Coupon GetByCode(string code)
        {
            return _couponData.GetByCode(code);
        }

        public List<Coupon> GetBySearchTitle(string title)
        {
            return _couponData.GetBySearchTitle(title);
        }
    }
}
