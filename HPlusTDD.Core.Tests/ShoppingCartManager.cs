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
        if (ContainsItem(_shoppingCart,request.Item))
        {
            updateItemQuantity(request.Item);
        }
        else
        {
            _shoppingCart.Add(request.Item);
        }
        return new AddToCartResponse()
        {
            Items = _shoppingCart.ToArray()
        };
    }

    private bool ContainsItem(List<AddToCartItem> shoppingCart, AddToCartItem item)
    {
        foreach (var shoppingCartItem in _shoppingCart)
        {
            if (shoppingCartItem.ArticleId.Equals(item.ArticleId))
            {
                return true;
            }
        }

        return false;
    }

    private void updateItemQuantity(AddToCartItem item)
    {
        foreach (var itemInCart in _shoppingCart)
        {
            if (itemInCart.ArticleId.Equals(item.ArticleId))
            {
                itemInCart.Quantity += item.Quantity;
            } 
        }
    }
}