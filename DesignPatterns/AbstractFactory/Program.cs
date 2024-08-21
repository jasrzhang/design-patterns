using AbstractFactory;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new BelgiumShippingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCardPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();