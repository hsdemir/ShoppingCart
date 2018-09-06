using ShoppingCart.Model;

namespace ShoppingCart.Business.Interface
{
    public interface IDeliveryBusiness
    {
        Delivery CostCalculator(Cart cart); 
    }
}
