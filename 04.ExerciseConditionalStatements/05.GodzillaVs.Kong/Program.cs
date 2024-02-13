using System;
using System.Text;

namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            double decorCoast = 0.1 * budget;
            double cloathingCoast = statists * dressPrice;
            if (statists > 150)
            {
                cloathingCoast = cloathingCoast - 0.1 * cloathingCoast;
            }
            double totalCoast = decorCoast + cloathingCoast;

            if (budget >= totalCoast)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCoast:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCoast - budget:f2} leva more.");
            }
        }
    }
}
