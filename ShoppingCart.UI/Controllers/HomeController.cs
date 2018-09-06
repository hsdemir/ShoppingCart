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
        private IDeliveryBusiness _deliveryBusines;

        public HomeController(ICartBusiness cartBusiness,
                              ICategoryBusiness categoryBusiness,
                              IProductBusiness productBusiness,
                              ICampaignBusiness campaignBusiness,
                              ICouponBusiness couponBusiness,
                              IDeliveryBusiness deliveryBusiness)
        {
            _cartBusiness = cartBusiness;
            _categoryBusiness = categoryBusiness;
            _productBusiness = productBusiness;
            _campaignBusiness = campaignBusiness;
            _couponBusiness = couponBusiness;
            _deliveryBusines = deliveryBusiness;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndirimsizAlisveris()
        {
            //Ürünleri getir
            var product1 = _productBusiness.GetById(104);
            var product2 = _productBusiness.GetById(105);

            //Sepet nesnesini oluştur
            var cart = new Cart();

            //Sepete ürünleri ekle
            cart = _cartBusiness.AddProduct(cart, product1, 1);
            cart = _cartBusiness.AddProduct(cart, product2, 1);

            //Kampanyaları kontrol et ve uygula
            cart = _cartBusiness.ApplyCampaigns(cart);

            //Kupon koduna ait kupon varsa ve indirimi geçerli ise uygula
            cart = _cartBusiness.ApplyCoupon(cart, "numubt1m41uf"); //250 TL alışveriş için 20% indirim
            
            //Sepet için teslimat tutarını hesapla
            cart = _deliveryBusines.CostCalculator(cart);

            return View();
        }
    }
}