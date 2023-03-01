namespace HPlusTDD.Core;

public class ShoppingCartTests
{
    [Setup]
    public void setup()
    {
        
    }

    [Test]
    public void ShouldReturnArticleAddedToCart()
    {
        var item = new AddToCartItem()
        {
            ArticleId = 42,
            Quantity = 5
        };

        var request = new AddToCartRequest()
        {
            Item = item
        };

        var manager = new ShoppingCartManager();

        AddToCartResponse response = manager.AddToCart(request);

        Assert.NotNull(response);
        Assert.Contains(item, response);

    }
    
    [Test]
    public void ShouldReturnArticlesAddedToCart()
    {
        var item1 = new AddToCartItem()
        {
            ArticleId = 42,
            Quantity = 5
        };
        var item2 = new AddToCartItem()
        {
            ArticleId = 43,
            Quantity = 10
        };

        var request1 = new AddToCartRequest()
        {
            Item = item1
        };

        var request2 = new AddToCartRequest()
        {
            Item = item2;
        };

        var manager = new ShoppingCartManager();

        AddToCartResponse response = manager.AddToCart(request1);
        response = manager.AddToCart(request2);

        Assert.NotNull(response);
        Assert.Contains(item1, response.Items);
        Assert.Contains(item2, response.Items);

    }

    [Test]
    public void ShouldUpdateQuantityWhenArticleIsAddedMultipleTimes()
    {
        var item1 = new AddToCartItem()
        {
            ArticleId = 20,
            Quantity = 5
        };
        var item2 = new AddToCartItem()
        {
            ArticleId = 20,
            Quantity = 10
        };

        var request1 = new AddToCartRequest()
        {
            Item = item1
        };

        var request2 = new AddToCartRequest()
        {
            Item = item2
        };

        var manager = new ShoppingCartManager();
        var response = manager.AddToCart(request1);
        response = manager.AddToCart(request2);

        Assert.That(response.Items[0].Quantity == 15);
    }
}
