using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            test.AddCustomer("Jorma Immonen", "Palanderinkatu 3", 45678);
            test.AddCustomer("Antti Vihtori", "Rasinrinne 3", 13579);

            test.AddOrder(1);
            test.AddOrder(2);
            test.AddOrder(3);
            test.AddOrder(4);

            test.AddOrderItem(0, "PS4");
            test.AddOrderItem(1, "XBOX");
            test.AddOrderItem(2, "PC");
            test.AddOrderItem(3, "Headphone");
            test.AddOrderItem(4, "CPU I5");
            test.AddOrderItem(5, "Shovel");
            test.AddOrderItem(6, "Nokia 3310");
            test.AddOrderItem(7, "WII");

            test.AddItemToOrder(0, 0);
            test.AddItemToOrder(0, 1);
            test.AddItemToOrder(0, 2);
            test.AddItemToOrder(1, 3);
            test.AddItemToOrder(2, 4);
            test.AddItemToOrder(2, 5);
            test.AddItemToOrder(3, 6);
            test.AddItemToOrder(3, 7);

            test.AddOrderToCustomer(0, 0);
            test.AddOrderToCustomer(0, 1);
            test.AddOrderToCustomer(1, 2);
            test.AddOrderToCustomer(1, 3);

            test.customers[0].ShowOrders();
            test.customers[1].ShowOrders();

            Console.ReadKey();
        }
    }
}
