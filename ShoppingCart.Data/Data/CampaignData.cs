using ShoppingCart.Data.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using System.Linq;

namespace ShoppingCart.Data
{
    public class CampaignData : ICampaignData
    {
        private List<Campaign> _campaignList = new List<Campaign> {
            new Campaign { Id = 1, Title ="Giyim ve ayakkabı ürünlerinde 3 üzeri ürün alana 20% indirim.", MinimumProduct = 4, Discount = 20, DiscountType = DiscountType.Rate, Categories = new List<Category> { new Category { Id = 1, Title = "Giyim" }, new Category { Id = 3, Title = "Ayakkabı" } }  },
            new Campaign { Id = 1, Title ="Aksesuar ürünlerinde 5 üzeri ürün alana 50% indirim.", MinimumProduct = 6, Discount = 50, DiscountType = DiscountType.Rate, Categories = new List<Category> { new Category { Id = 2, Title = "Aksesuar" } } },
            new Campaign { Id = 1, Title ="Spor ürünlerine özel, 5 üzeri ürün alana her ürün için 5 TL indirim.", MinimumProduct = 6, Discount = 5, DiscountType = DiscountType.Amount, Categories = new List<Category> { new Category { Id = 4, Title = "Spor" } } }
        };

        public List<Campaign> GetList()
        {
            return _campaignList;
        }

        public Campaign GetById(int id)
        {
            return _campaignList.FirstOrDefault(x => x.Id == id);
        }

        public List<Campaign> GetByCategoryId(int categoryId)
        {
            return _campaignList.Where(x => x.Categories.Any(z => z.Id == categoryId)).ToList();
        }

        public List<Campaign> GetBySearchTitle(string title)
        {
            return _campaignList.Where(x => x.Title.ToLower().Contains(title.ToLower())).ToList();
        }
    }
}
