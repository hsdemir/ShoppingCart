using ShoppingCart.Business.Interface;
using System.Linq;
using ShoppingCart.Model;
using ShoppingCart.Data.Constant;

namespace ShoppingCart.Business
{
    public class DeliveryBusiness : IDeliveryBusiness
    {
        public Delivery CostCalculator(Cart cart)
        {
            var delivery = new Delivery();

            delivery.NumberOfDeliveries = cart.Products.Select(p => p.Category.Parent).Distinct().Count(); //Sepetteki ürünlerin faklı olan üst kategorilerinin sayısı.
            delivery.NumberOfProducts = cart.Products.Count; //Sepetteki farklı ürünlerin sayısı.
            var costPerDelivery = DeliveryConstants.CostPerDelivery;
            var costPerProduct = DeliveryConstants.CostPerProduct;

            //Teslimat hesaplama formulüne göre toplam teslimat tutarı hesaplandı.
            delivery.TotalCost = (costPerDelivery * delivery.NumberOfDeliveries) + (costPerProduct * delivery.NumberOfProducts) + DeliveryConstants.FixedCost;

            return delivery;
        }
    }
}
