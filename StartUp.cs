using System;

namespace Customers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Kuncho", DriverType.Bycicle);
            Console.WriteLine(c1.VIPLevel);
            
        }
    }
        
}
