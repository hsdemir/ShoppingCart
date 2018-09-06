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
            var campaignList = _campaignBusiness.GetList();
            return View(campaignList);
        }

        public ActionResult CartInfo()
        {
            var cart = TempData["cart"] as Cart;
            if (cart == null) return RedirectToAction("Index");

            return View(cart);
        }

        public ActionResult Kampanya1Indirimsiz()
        {
            //Ürünleri getir.
            var product1 = _productBusiness.GetById(104);
            var product2 = _productBusiness.GetById(105);

            //Sepet nesnesini oluştur.
            var cart = new Cart();

            //Sepete ürünleri ekle.
            cart = _cartBusiness.AddProduct(cart, product1, 1);
            cart = _cartBusiness.AddProduct(cart, product2, 1);

            //Kampanya, kupon, teslimat hesaplamalarını yap.
            //250 TL alışveriş için 20% indirim kuponu.
            cart = ApplyDiscountsAndDelivery(cart, "numubt1m41uf");
            TempData["cart"] = cart;

            return RedirectToAction("CartInfo");
        }

        public ActionResult Kampanya1Indirimli()
        {
            //Ürünleri getir.
            var product1 = _productBusiness.GetById(101);
            var product2 = _productBusiness.GetById(102);
            var product3 = _productBusiness.GetById(103);
            var product4 = _productBusiness.GetById(304);

            //Sepet nesnesini oluştur.
            var cart = new Cart();

            //Sepete ürünleri ekle.
            cart = _cartBusiness.AddProduct(cart, product1, 1);
            cart = _cartBusiness.AddProduct(cart, product2, 1);

            //Kampanya, kupon, teslimat hesaplamalarını yap.
            //250 TL alışveriş için 20% indirim kuponu.
            cart = ApplyDiscountsAndDelivery(cart, "numubt1m41uf");
            TempData["cart"] = cart;

            return RedirectToAction("CartInfo");
        }

        public ActionResult Kampanya2Indirimli()
        {
            //Ürünleri getir.
            var product1 = _productBusiness.GetById(201);
            var product2 = _productBusiness.GetById(202);
            var product3 = _productBusiness.GetById(203);
            var product4 = _productBusiness.GetById(204);
            var product5 = _productBusiness.GetById(205);
            var product6 = _productBusiness.GetById(206);
            var product7 = _productBusiness.GetById(207);

            //Sepet nesnesini oluştur.
            var cart = new Cart();

            //Sepete ürünleri ekle.
            cart = _cartBusiness.AddProduct(cart, product1, 1);
            cart = _cartBusiness.AddProduct(cart, product2, 1);
            cart = _cartBusiness.AddProduct(cart, product3, 2);
            cart = _cartBusiness.AddProduct(cart, product4, 1);
            cart = _cartBusiness.AddProduct(cart, product5, 1);
            cart = _cartBusiness.AddProduct(cart, product6, 3);
            cart = _cartBusiness.AddProduct(cart, product7, 1);

            //Kampanya, kupon, teslimat hesaplamalarını yap.
            //250 TL alışveriş için 20% indirim kuponu.
            cart = ApplyDiscountsAndDelivery(cart, "numubt1m41uf");
            TempData["cart"] = cart;

            return RedirectToAction("CartInfo");
        }
        public ActionResult Kampanya3Indirimli()
        {
            //Ürünleri getir.
            var product1 = _productBusiness.GetById(400);
            var product2 = _productBusiness.GetById(401);
            var product3 = _productBusiness.GetById(402);
            var product4 = _productBusiness.GetById(403);
            var product5 = _productBusiness.GetById(404);
            var product6 = _productBusiness.GetById(405);

            //Sepet nesnesini oluştur.
            var cart = new Cart();

            //Sepete ürünleri ekle.
            cart = _cartBusiness.AddProduct(cart, product1, 1);
            cart = _cartBusiness.AddProduct(cart, product2, 1);
            cart = _cartBusiness.AddProduct(cart, product3, 2);
            cart = _cartBusiness.AddProduct(cart, product4, 3);
            cart = _cartBusiness.AddProduct(cart, product5, 2);
            cart = _cartBusiness.AddProduct(cart, product6, 2);

            //Kampanya, kupon, teslimat hesaplamalarını yap.
            //250 TL alışveriş için 20% indirim kuponu.
            cart = ApplyDiscountsAndDelivery(cart, "numubt1m41uf");
            TempData["cart"] = cart;

            return RedirectToAction("CartInfo");
        }

        private Cart ApplyDiscountsAndDelivery(Cart cart, string couponCode)
        {
            //Kampanyaları kontrol et ve uygula.
            cart = _cartBusiness.ApplyCampaigns(cart);

            //Kupon koduna ait kupon varsa ve indirimi geçerli ise uygula.
            cart = _cartBusiness.ApplyCoupon(cart, couponCode);

            //Sepet için teslimat tutarını hesapla.
            cart = _deliveryBusines.CostCalculator(cart);

            return cart;
        }
    }
}