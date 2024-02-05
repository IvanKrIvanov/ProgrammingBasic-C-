using System;

class Program
{
    static void Main()
    {
        int annualTrainingFee = int.Parse(Console.ReadLine());

        double basketballShoesPrice = 0.6 * annualTrainingFee;
        double basketballJerseyPrice = 0.8 * basketballShoesPrice;
        double basketballBallPrice = 0.25 * basketballJerseyPrice;
        double basketballAccessoriesPrice = 0.2 * basketballBallPrice;

        double totalExpenses = annualTrainingFee + basketballShoesPrice + basketballJerseyPrice + basketballBallPrice + basketballAccessoriesPrice;

        Console.WriteLine($"{totalExpenses:F2}");
    }
}
