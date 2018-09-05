using ShoppingCart.Model;
using ShoppingCart.Business.Interface;
using System.Web.Mvc;

namespace ShoppingCart.UI.Controllers
{
    public class HomeController : Controller
    {
        private ICartBusiness _cartBusiness;
        private ICategoryBusiness _categoryBusiness;
        private IProductBusiness _productBusiness;
        private ICampaignBusiness _campaignBusiness;
        private ICouponBusiness _couponBusiness;

        public HomeController(ICartBusiness cartBusiness, 
                              ICategoryBusiness categoryBusiness, 
                              IProductBusiness productBusiness,
                              ICampaignBusiness campaignBusiness,
                              ICouponBusiness couponBusiness)
        {
            _cartBusiness = cartBusiness;
            _categoryBusiness = categoryBusiness;
            _productBusiness = productBusiness;
            _campaignBusiness = campaignBusiness;
            _couponBusiness = couponBusiness;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}