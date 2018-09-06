using ShoppingCart.Model;

namespace ShoppingCart.Business.Interface
{
    public interface IDeliveryBusiness
    {
        Cart CostCalculator(Cart cart); 
    }
}
