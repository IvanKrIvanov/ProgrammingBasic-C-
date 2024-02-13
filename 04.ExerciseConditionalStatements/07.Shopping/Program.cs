using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuCoast = gpuCount * 250;

            double cpuPrice = 0.35 * gpuCoast;
            double cpuCoast = cpuCount * cpuPrice;

            double ramPrice = 0.1 * gpuCoast;
            double ramCoast = ramCount  * ramPrice;

            double totalCoast = gpuCoast + cpuCoast + ramCoast;
            if (gpuCoast > cpuCoast)
            {
                totalCoast = totalCoast - 0.15 * totalCoast;
            }
            if (budget >= totalCoast)
            {
                Console.WriteLine($"You have {budget - totalCoast:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCoast - budget:f2} leva more!");
            }
            }
    }
}
