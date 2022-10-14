using System;
using System.Collections.Generic;
namespace Customers
{
    public class Customer
    {
        private static decimal annualRefundCoef = 15;
        private const int maxVIPLvl = 10;
        public string Name { get; private set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public DriverType DriverType { get; set; }
        public int VIPLevel { get; private set; } = 0;
        public List<Order> Orders { get; set; } = new List<Order>();
        public IReadOnlyCollection<Order> Orders1 { get { return Orders; } }
        public Customer(string Name, DriverType driverType)
        {
            this.Name = Name;

        }
        public int ImproveVIP()
        {
            if (VIPLevel == maxVIPLvl)
            {
                Console.WriteLine($"Maximal VIP= { maxVIPLvl } reached already");
            }
            if (VIPLevel < maxVIPLvl)
            {
                VIPLevel++;
            }
            return VIPLevel;
        }
        public decimal GetSpentMoney()
        {
            decimal totalCost = 0;

            foreach (Order order in Orders)
            {
                totalCost += order.Price;
            }


            return totalCost;
        }
        public void RegisterOrder(Order order)
        {
            Orders.Add(order);
            
        }
    }
}
