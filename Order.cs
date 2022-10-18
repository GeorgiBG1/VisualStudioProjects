using System;
namespace Customers
{
    public class Order
    {
        private DateTime orderDate;
        private decimal price;
        public string Description { get; set; }
        public DateTime Date
        {
            get => orderDate;
            private set
            {
                if (value.Year < DateTime.UtcNow.Year)
                {
                    Console.WriteLine("Invalid date");
                    orderDate = DateTime.UtcNow;           
                }
                else
                {
                    orderDate = value;
                }

            }
        }
        public decimal Price { get=> price; set { if (Price < 0) { Price = 0; Console.WriteLine("Invalid Price value!"); } } }
        public Order(DateTime date, string desc, decimal price)
        {
            this.orderDate = date;
            this.Description = desc;
            this.Price = price;
        }
    }
}
