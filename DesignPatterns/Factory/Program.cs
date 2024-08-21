using Factory;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>() { new CodeDiscountFacotry(Guid.NewGuid()), new CountryDiscountFactory("BE") };

foreach(var fact in factories)
{
    var discountService = fact.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} " + $"coming from {discountService}");
}