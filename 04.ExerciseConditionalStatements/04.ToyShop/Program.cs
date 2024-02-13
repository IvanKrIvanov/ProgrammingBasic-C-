using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int munions = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double profit = puzzle * 2.6 + doll * 3 + bear * 4.1 + munions * 8.2 + truck * 2;

            int totalToyCount = puzzle + doll + bear + munions + truck;
            if (totalToyCount >= 50)
            {
                profit = profit - 0.25 * profit;
            }
            profit = profit * 0.9;

            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
            }
           

        }
    }
}
