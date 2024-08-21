using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Build a factory contains all services
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostsService();
    }

    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }
    public interface IShippingCostService
    {
        decimal ShippingCosts { get; }
    }

    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    public class BelgiumShippingCostsService : IShippingCostService
    {
        public decimal ShippingCosts => 20;
    }

    public class FranceShippingCostsService : IShippingCostService
    {
        public decimal ShippingCosts => 25;
    }

    public class BelgiumShippingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
           return new BelgiumDiscountService();
        }

        public IShippingCostService CreateShippingCostsService()
        {
            return new BelgiumShippingCostsService();
        }
    }

    public class FranceShoppingCardPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }


    /// <summary>
    /// Client class
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostService _shippingCostService;
        private int _orderCosts;

        // Constructor
        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostService = factory.CreateShippingCostsService();
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = " + $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage)}");
        }
    }


}
