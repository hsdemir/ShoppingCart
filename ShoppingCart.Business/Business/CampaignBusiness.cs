using ShoppingCart.Business.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;
using ShoppingCart.Data.Interface;

namespace ShoppingCart.Business
{
    public class CampaignBusiness : ICampaignBusiness
    {
        private ICampaignData _campaignData;
        public CampaignBusiness(ICampaignData campaignData)
        {
            _campaignData = campaignData;
        }

        public List<Campaign> GetList()
        {
            return _campaignData.GetList();
        }

        public Campaign GetById(int id)
        {
            return _campaignData.GetById(id);
        }

        public List<Campaign> GetByCategoryId(int categoryId)
        {
            return _campaignData.GetByCategoryId(categoryId);
        }

        public Campaign GetByTitle(string title)
        {
            return _campaignData.GetByTitle(title);
        }
    }
}
