using ShoppingCart.Data.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Data
{
    public class CampaignData : ICampaignData
    {
        public List<Campaign> campaignList = new List<Campaign> {
            new Campaign { Id = 1, Title ="Giyim ürünlerinde 3 üzeri ürün alana 20% indirim.", MinimumProduct = 3, Discount = 20, DiscountType = DiscountType.Rate, Category = new Category { Id = 1, Title = "Giyim" }  },
            new Campaign { Id = 1, Title ="Aksesuar ürünlerinde 5 üzeri ürün alana 50% indirim.", MinimumProduct = 5, Discount = 50, DiscountType = DiscountType.Rate, Category = new Category { Id = 2, Title = "Aksesuar" } },
            new Campaign { Id = 1, Title ="Spor ürünlerine özel, 5 üzeri ürün alana her ürün için 5 TL indirim.", MinimumProduct = 5, Discount = 5, DiscountType = DiscountType.Amount, Category = new Category { Id = 4, Title = "Spor" } }
        };

        public Campaign GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Campaign GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
