using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Business.Interface;
using ShoppingCart.Business;
using ShoppingCart.Data;
using ShoppingCart.Model;

namespace ShoppingCart.Test.Business
{
    [TestClass]
    public class CampaignBusinessTests
    {
        private ICampaignBusiness _campaignBusiness;
        private ICouponBusiness _couponBusiness;
        private IProductBusiness _productBusiness;
        private ICartBusiness _cartBusiness;
        public CampaignBusinessTests()
        {
            _campaignBusiness = new CampaignBusiness(new CampaignData());
            _couponBusiness = new CouponBusiness(new CouponData());
            _productBusiness = new ProductBusiness(new ProductData());
            _cartBusiness = new CartBusiness(new CampaignBusiness(new CampaignData()), new CouponBusiness(new CouponData()));
        }

        [TestMethod]
        public void Correct_Coupon_Discount_Work()
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

            //Sepet işlemlerini gerçekleştir.
            cart = _cartBusiness.ApplyCampaigns(cart);

            //Test kuponunu getir.
            var testCoupon = _couponBusiness.GetByCode("numubt1m41uf");

            //Sepete kupon indirimi uygulanmış olması gerekiyor mu?
            var expectedValue = cart.Amount >= testCoupon.MinimumAmount;

            //Kupon koduna ait kupon varsa ve indirimi geçerli ise uygula.
            cart = _cartBusiness.ApplyCoupon(cart, testCoupon.Code);

            //Sepete kupon uygulanmış mı?
            var actualValue = cart.ValidCoupon != null;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
