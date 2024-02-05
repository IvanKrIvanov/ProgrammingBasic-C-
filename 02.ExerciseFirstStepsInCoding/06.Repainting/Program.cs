using System;

class Program
{
    static void Main()
    {
        int nylonQuantity = int.Parse(Console.ReadLine());
        int paintQuantity = int.Parse(Console.ReadLine());
        int thinnerQuantity = int.Parse(Console.ReadLine());
        int hoursOfWork = int.Parse(Console.ReadLine());

        double nylonPricePerSquareMeter = 1.50;
        double paintPricePerLiter = 14.50;
        double thinnerPricePerLiter = 5.00;
        double plasticBagsPrice = 0.40;

        double totalNylonPrice = (nylonQuantity + 2) * nylonPricePerSquareMeter;
        double totalPaintPrice = (paintQuantity + (paintQuantity * 0.1)) * paintPricePerLiter;
        double totalThinnerPrice = thinnerQuantity * thinnerPricePerLiter;
        double totalPlasticBagsPrice = plasticBagsPrice * 1;

        double totalMaterialCost = totalNylonPrice + totalPaintPrice + totalThinnerPrice + totalPlasticBagsPrice;
        double totalLaborCost = totalMaterialCost * 0.30 * hoursOfWork;

        double totalCost = totalMaterialCost + totalLaborCost;

        Console.WriteLine($"{totalCost:F2}");
    }
}
