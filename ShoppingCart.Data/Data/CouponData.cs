using ShoppingCart.Data.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using System.Linq;

namespace ShoppingCart.Data
{
    public class CouponData : ICouponData
    {
        public List<Coupon> _couponList = new List<Coupon>
        {
            new Coupon { Code = "1o30qy5f78vi", Title = "100 tl ve üzeri alışveriş için 10%'luk indirim.", MinimumAmount = 100, Discount = 10 },
            new Coupon { Code = "numubt1m41uf", Title = "250 tl ve üzeri alışveriş için 20%'lik indirim.", MinimumAmount = 250, Discount = 20 },
        };

        public List<Coupon> GetList()
        {
            return _couponList;
        }

        public Coupon GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Coupon GetByCode(string code)
        {
            return _couponList.FirstOrDefault(x => x.Code == code);
        }

        public List<Coupon> GetBySearchTitle(string title)
        {
            return _couponList.Where(x => x.Title.ToLower().Contains(title.ToLower())).ToList();
        }
    }
}
