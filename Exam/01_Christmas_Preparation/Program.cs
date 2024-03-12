using System;

namespace ChristmasPreparations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int rollsOfWrappingPaper = int.Parse(Console.ReadLine());
            int rollsOfFabric = int.Parse(Console.ReadLine());
            double litersOfGlue = double.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            // Цени на материалите
            double wrappingPaperPricePerRoll = 5.80;
            double fabricPricePerRoll = 7.20;
            double gluePricePerLiter = 1.20;

            // Изчисления
            double totalWrappingPaperCost = rollsOfWrappingPaper * wrappingPaperPricePerRoll;
            double totalFabricCost = rollsOfFabric * fabricPricePerRoll;
            double totalGlueCost = litersOfGlue * gluePricePerLiter;

            double totalMaterialsCost = totalWrappingPaperCost + totalFabricCost + totalGlueCost;

            // Изчисляваме намалението
            double discountAmount = totalMaterialsCost * (discountPercentage / 100.0);
            double finalCost = totalMaterialsCost - discountAmount;

            // Отпечатване на резултата
            Console.WriteLine($"{finalCost:F3}");
        }
    }
}
