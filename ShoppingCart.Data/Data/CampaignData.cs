using ShoppingCart.Data.Interface;
using System;
using System.Collections.Generic;
using ShoppingCart.Model;

namespace ShoppingCart.Data
{
    public class CampaignData : ICampaignData
    {
        public Campaign GetById(int id)
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
