﻿using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using System.Linq;

namespace ShoppingCart.Business
{
    public class CartBusiness : ICartBusiness
    {
        private ICampaignBusiness _campaignBusiness;
        private ICouponBusiness _couponBusiness;
        public CartBusiness(ICampaignBusiness campaignBusiness, ICouponBusiness couponBusiness)
        {
            _campaignBusiness = campaignBusiness;
            _couponBusiness = couponBusiness;
        }

        public Cart AddProduct(Cart cart, Product product, int Quantity)
        {
            if (cart.Products == null) cart.Products = new List<Product>();
            product.Quantity = Quantity;
            cart.Products.Add(product);

            return cart;
        }

        public Cart ApplyCampaigns(Cart cart)
        {
            var validCampaigns = new List<Campaign>(); //Sepette bulunan ürün kategorileri için uygun olan kampanyaları eklemek için kullanılır.
            var allCampaigns = _campaignBusiness.GetList(); //Kapmanya listesini getir.
            if (allCampaigns != null && allCampaigns.Count > 0) //Kampanya listesi dolu mu?
            {
                foreach (var campaign in allCampaigns) //Kampanyalarda dön.
                {
                    var productCount = cart.Products.Where(p => campaign.Categories.Any(c => c.Id == p.Category.Parent.Id)).Select(x => x.Quantity).Sum(); //Sepetteki ürünlerden, kampanya kategorilerine ait olan ürün sayısını getir.
                    if (campaign.MinimumProduct <= productCount) //Sepetteki ürün kategorisi uyan ürünlerin sayısı, kampanyadaki minimum ürün sayısından eşit veya büyük mü?
                        validCampaigns.Add(campaign);
                }
            }

            //Ürün adetleride dikkate alınarak, sepetteki ürünlerin toplam tutarı sepete girildi.
            cart.Amount = cart.Products.Sum(p => p.Price * p.Quantity);

            //Sepetteki ürünler için geçerli kampanya listesi dolu mu?
            if (validCampaigns != null && validCampaigns.Count > 0)
            {
                cart.ValidCampaign = validCampaigns.OrderByDescending(x => x.Discount).First(); //Liste içerisinden indirim oranı en yüksek olan kampanyayı seç.

                //Not: Maximum indirim oranına göre kampanya seçiminde, listedeki kampanyaların indirim tiplerinde rate ve amount varsa.
                //Ayrıca, indirim tipi amount olan kampanyanın indirimi tüm ürünler için toplanarak maximum indirimin hangi kampanyada olduğu belirlenmesi gerekir.
                //Zaman yeterse bu kontrolüde ekleyeceğim.

                if (cart.ValidCampaign.DiscountType == DiscountType.Rate) //Kampanyanın indirim tipi oran mı?
                {
                    cart.DiscountAmount = cart.Amount - (cart.Amount * (cart.ValidCampaign.Discount * 0.01)); //Kampanyadaki indirim oranı kadar indirim yapıldı.
                }
                else if (cart.ValidCampaign.DiscountType == DiscountType.Amount) //Kampanyanın indirim tipi tutar mı?
                {
                    var productCount = cart.Products.Sum(p => p.Quantity);
                    cart.DiscountAmount = cart.Amount - (cart.ValidCampaign.Discount * productCount); //Kampanyadaki indirim tutarı kadar her ürün için indirim yapıldı.
                }
            }

            return cart;
        }

        public Cart ApplyCoupon(Cart cart, string couponCode)
        {
            var coupon = _couponBusiness.GetByCode(couponCode); //Kupon koduna göre kuponu getir.

            if (coupon != null) //Kupon var mı?
            {
                cart.ValidCoupon = coupon; //Sepetteki geçerli kupon nesnesine kuponu ekle.

                if (coupon.MinimumAmount <= cart.Amount) //Sepet tutarı, kuponun minimum tutarına eşit yada fazla mı?
                {
                    if (cart.DiscountAmount == 0) //Sepete daha önce indirim uygulanmadı ise.
                    {
                        cart.DiscountAmount = cart.Amount - (cart.Amount * (coupon.Discount * 0.01)); //Sepet toplam tutarına indirim uygula.
                    }
                    else //Sepete daha önce indirim uygulandı ise.
                    {
                        cart.DiscountAmount = cart.DiscountAmount - (cart.Amount * (coupon.Discount * 0.01)); //Sepet indirim tutarına indirim uygula.
                    }
                }
            }

            return cart;
        }

        public double GetCampaignDiscount(Cart cart)
        {
            return cart.ValidCampaign?.Discount ?? 0;
        }

        public double GetCouponDiscount(Cart cart)
        {
            return cart.ValidCoupon?.Discount ?? 0;
        }
    }
}
