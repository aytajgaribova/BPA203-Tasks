using System;
using ConsoleApp2;
namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);

            DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);


            DrinkOrder order3 = new DrinkOrder(103, "Vüqar", DrinkType.Juice, DrinkSize.Small);
            order3.DisplayOrder();


            foreach (var d in Enum.GetValues(typeof(DrinkType)))
                Console.WriteLine(d);

            foreach (var s in Enum.GetValues(typeof(DrinkSize)))
                Console.WriteLine(s);

            foreach (var st in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(st);

            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(DrinkSize.Large.ToString());

            Console.WriteLine("\n=== Parse() nümunələri ===");
            DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            Console.WriteLine($"Parsed Drink: {parsedDrink}");
            Console.WriteLine($"Parsed Size: {parsedSize}");

            // --- Statistika ---
            Console.WriteLine($"1-ci sifarişin qiyməti: {order1.Price} ");
            Console.WriteLine($"2-ci sifarişin qiyməti: {order2.Price} ");
            Console.WriteLine($"3-cü sifarişin qiyməti: {order3.Price} ");

            decimal total = order1.Price + order2.Price + order3.Price;
            Console.WriteLine($"{total}");
        }
    }
}  
