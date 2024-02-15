using System;

class Program
{
    static void Main()
    {
        string flowerType = Console.ReadLine();
        int flowerCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double flowerPrice = 0.0;
        double totalPrice = 0.0;

        switch (flowerType)
        {
            case "Roses":
                flowerPrice = 5.00;
                totalPrice = flowerCount * flowerPrice;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.9; // 10% discount
                }
                break;
            case "Dahlias":
                flowerPrice = 3.80;
                totalPrice = flowerCount * flowerPrice;
                if (flowerCount > 90)
                {
                    totalPrice *= 0.85; // 15% discount
                }
                break;
            case "Tulips":
                flowerPrice = 2.80;
                totalPrice = flowerCount * flowerPrice;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.85; // 15% discount
                }
                break;
            case "Narcissus":
                flowerPrice = 3.00;
                totalPrice = flowerCount * flowerPrice;
                if (flowerCount < 120)
                {
                    totalPrice *= 1.15; // 15% increase
                }
                break;
            case "Gladiolus":
                flowerPrice = 2.50;
                totalPrice = flowerCount * flowerPrice;
                if (flowerCount < 80)
                {
                    totalPrice *= 1.20; // 20% increase
                }
                break;
        }

        double moneyLeft = budget - totalPrice;

        if (moneyLeft >= 0)
        {
            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", flowerCount, flowerType, moneyLeft);
        }
        else
        {
            double moneyNeeded = Math.Abs(moneyLeft);
            Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyNeeded);
        }
    }
}
