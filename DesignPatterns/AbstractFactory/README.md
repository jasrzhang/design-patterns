# Abstract Factory #
> The intent of the abstract factory pattern is to provide an interface for creating families of related or dependent objects without wpecifying their concret classes



##  Implementation senario - Shopping Cart
> - DiscountService by Country
> - ShippingCostService by country


##### Tight Coupling? ####
	var belgiumDiscountService = new BelgiumDiscountService();
	var discount = belgiumDiscountService.Discountpercentage;

	var belgiumShippingCostsService = new BelgiumShippingCostsService();
	var shippingCosts = belgiumShippingCostsService.ShippingCosts

#### Use Abstract Factory Pattern ####

	IShoppingCartPurchaseFactory	-> Service Family
	IShippingCostsService.CreateShippingCostsService()	-> IDiscountService
	IDiscountService.CreateDiscountService()	-> IShippingCostsService

- Use an abstract base class when you need to provide some basic functionality that can potentially be overridden

# Use Cases #
- When a system should be independent of how its products are created, composed and represented
- When you want to provide a class library of products and you only want to reveal their interfaces, not their implementations
- When a system should be configured with one of multiple families of products
- When a family of related product objects is designed to be used together and you want to enforce this constraint

***
> Examples:
>
> - Supporting multiple languages
>
> - Converting documents to different formats
>
> - Abstracting away your database access layer
>
> - Supporting different application themes or styles


***
# Pattern Consequnces #
- It isolates concrete classes, because it encapsulates the responsibility and the process of creating product objects
- New products can eaisly be introduced without breaking client code: `open/close principle `
- Code to create products is contained in one place: `single responsibility principle `
- It makes exchanging product families easy
- It promotes consistency among products
- Supporting new kinds of products is rather DIFFICULT (need change all implementations)
