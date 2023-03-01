namespace HPlusTDD.Core;

public class ShoppingCartManager
{
    public AddToCartResponse AddToCart(AddToCartRequest request)
    {
        return new AddToCartResponse()
        {
            Items = new AddToCartItem[] { request.Item }
        };
    }
}