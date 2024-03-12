using System;

namespace BacheloretteParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckySurprises = int.Parse(Console.ReadLine());

            // Цени на артикулите
            double loveMessagePrice = 0.60;
            double waxRosePrice = 7.20;
            double keychainPrice = 3.60;
            double caricaturePrice = 18.20;
            double luckySurprisePrice = 22.00;

            // Изчисления
            double totalIncome = loveMessages * loveMessagePrice +
                                waxRoses * waxRosePrice +
                                keychains * keychainPrice +
                                caricatures * caricaturePrice +
                                luckySurprises * luckySurprisePrice;

            int totalItemsSold = loveMessages + waxRoses + keychains + caricatures + luckySurprises;

            if (totalItemsSold >= 25)
            {
                totalIncome *= 0.65; // 35% отстъпка
            }

            double hostingExpense = totalIncome * 0.10;
            double remainingMoney = totalIncome - hostingExpense;

            // Изход
            if (remainingMoney >= partyPrice)
            {
                Console.WriteLine($"Yes! {remainingMoney - partyPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - remainingMoney:F2} lv needed.");
            }
        }
    }
}
