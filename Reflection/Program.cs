using System;
using ClassLibrary;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order
            {
                ProductCount = 2,
                TotalAmount = 35,
                CreatedAt = DateTime.Parse("23/05/2022"),

            };

            Order order2 = new Order
            {
                ProductCount = 3,
                TotalAmount = 40,
                CreatedAt = DateTime.Parse("05/10/2020"),

            };
            Order order3 = new Order
            {
                ProductCount = 4,
                TotalAmount = 45,
                CreatedAt = DateTime.Parse("12/12/2022"),

            };
            Order order4 = new Order
            {
                ProductCount = 5,
                TotalAmount = 55,
                CreatedAt = DateTime.Parse("12/05/2021"),

            };
            Order order5 = new Order
            {
                ProductCount = 6,
                TotalAmount = 65,
                CreatedAt = DateTime.Parse("10/09/2022"),

            };

            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            shop.AddOrder(order4);
            shop.AddOrder(order5);

            DateTime date = DateTime.Parse("09/06/2021");

            Console.WriteLine(":::orders avg with datetime:::");
            Console.WriteLine(shop.GetOrdersAvg(date));

            Console.WriteLine(":::Get orders avg:::");
            Console.WriteLine(shop.GetOrdersAvg());

            Console.WriteLine(":::Filter order by Price:::");
            foreach (var item in shop.FilterOrderByPrice(36, 66))
            {
                Console.WriteLine($"product no: {item.No} | product price: {item.TotalAmount}");
            };

            shop.RemoveOrderByNo(2);
            Console.WriteLine(":::after removing. Product list:::");
            foreach (var item in shop.Orders)
            {
                Console.WriteLine($"product no: {item.No} | product price: {item.TotalAmount} | product created at: {item.CreatedAt}");
            }
        }
    }
}
