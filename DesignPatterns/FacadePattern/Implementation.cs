using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// Subsystem
    /// </summary>
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId)
        {
            return customerId > 5;
        }
    }

    // Subsystem
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId)
        {
            // fake calculation for demo purpose
            return (customerId > 8) ? 10 : 20;
        }
    }

    /// <summary>
    /// Subsystem
    /// </summary>
    public class DayOfTheWeekFactorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }

    /// <summary>
    /// Facade
    /// </summary>
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();

        public double CalculateDiscountPercentage(int customerId)
        {
            if (!_orderService.HasEnoughOrders(customerId)) return 0;
            return _customerDiscountBaseService.CalculateDiscountBase(customerId) * _dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor();
        }
    }
}
