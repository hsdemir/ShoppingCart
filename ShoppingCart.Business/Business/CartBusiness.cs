using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using System.Linq;

namespace ShoppingCart.Business
{
    public class CartBusiness : ICartBusiness
    {
        private ICampaignBusiness _campaignBusiness;
        public CartBusiness(ICampaignBusiness campaignBusiness)
        {
            _campaignBusiness = campaignBusiness;
        }

        public Cart AddProduct(Cart cart, Product product)
        {
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
                    var productCount = cart.Products.Where(p => campaign.Categories.Any(c => c.Id == p.Category.Id)).ToList().Count; //Sepetteki ürünlerden, kampanya kategorilerine ait olan ürün sayısını getir.
                    var validCampaign = allCampaigns.Where(c => c.MinimumProduct <= productCount).OrderByDescending(x => x.MinimumProduct).FirstOrDefault(); //Bulunan ürün sayısına göre, en fazla ürün sayısı olan kampanyayı getir.
                    if (validCampaign != null && (validCampaigns != null && !validCampaigns.Any(c => c.Id == validCampaign.Id)))
                        validCampaigns.Add(validCampaign); //Bulunan geçerli kampanya id si, geçerli kampanyalar listesinde mevcut değilse, listeye ekle.
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
                    cart.DiscountAmount = cart.Amount * (cart.ValidCampaign.Discount * 0.01); //Kampanyadaki indirim oranı kadar indirim yapıldı.
                }
                else if (cart.ValidCampaign.DiscountType == DiscountType.Amount) //Kampanyanın indirim tipi tutar mı?
                {
                    var productCount = cart.Products.Sum(p => p.Quantity);
                    cart.DiscountAmount = cart.Amount - (cart.ValidCampaign.Discount * productCount); //Kampanyadaki indirim tutarı kadar her ürün için indirim yapıldı.
                }
            }

            return cart;
        }

        public bool ApplyCoupon(Cart cart, Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
