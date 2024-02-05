using System;

class Program
{
    static void Main()
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegetarianMenus = int.Parse(Console.ReadLine());

        double chickenMenuPrice = 10.35;
        double fishMenuPrice = 12.40;
        double vegetarianMenuPrice = 8.15;
        double dessertPercentage = 0.20;
        double deliveryPrice = 2.50;

        double totalFoodPrice = (chickenMenus * chickenMenuPrice) + (fishMenus * fishMenuPrice) + (vegetarianMenus * vegetarianMenuPrice);
        double dessertPrice = totalFoodPrice * dessertPercentage;
        double totalOrderPrice = totalFoodPrice + dessertPrice + deliveryPrice;

        Console.WriteLine($"{totalOrderPrice:F2}");
    }
}
