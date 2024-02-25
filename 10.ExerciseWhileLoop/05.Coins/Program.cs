using System;

namespace VendingMachineChange
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal changeAmount = decimal.Parse(Console.ReadLine());

            int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 }; // Списък с наличните монети във вендинг машината
            int[] coinCounts = new int[coins.Length];

            CalculateChange(changeAmount, coins, coinCounts);

            int totalCoins = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coinCounts[i] > 0)
                {
                    totalCoins += coinCounts[i];
                }
            }

            Console.WriteLine(totalCoins);
        }

        static void CalculateChange(decimal amount, int[] coins, int[] coinCounts)
        {
            int remainingAmount = (int)(amount * 100); 
            for (int i = 0; i < coins.Length; i++)
            {
                coinCounts[i] = remainingAmount / coins[i];
                remainingAmount %= coins[i];
            }
        }
    }
}
