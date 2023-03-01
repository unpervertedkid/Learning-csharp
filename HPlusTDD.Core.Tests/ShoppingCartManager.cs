namespace HPlusTDD.Core;

public class ShoppingCartManager
{
    private List<AddToCartItem> _shoppingCart;

    public ShoppingCartManager()
    {
        _shoppingCart = new List<AddToCartItem>();
    }
    public AddToCartResponse AddToCart(AddToCartRequest request)
    {
        _shoppingCart.Add(request.Item);
        return new AddToCartResponse()
        {
            Items = _shoppingCart.ToArray()
        };
    }
}