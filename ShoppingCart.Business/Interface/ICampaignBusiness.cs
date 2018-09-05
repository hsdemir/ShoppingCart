using ShoppingCart.Business.Interface;
using ShoppingCart.Model;
using System.Collections.Generic;

namespace ShoppingCart.Business.Interface
{
    public interface ICampaignBusiness : IBaseBusiness<Campaign>
    {
        List<Campaign> GetByCategoryId(int categoryId);
    }
}
