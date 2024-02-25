using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (ownedMoney < neededMoney && spendingCounter < 5)
            {
                string operation = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (operation == "save")
                {
                    ownedMoney += amount;
                    spendingCounter = 0;
                }
                else if (operation == "spend")
                {
                    ownedMoney = Math.Max(ownedMoney - amount, 0);
                    spendingCounter++;
                }
                daysCounter++;
            }


            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysCounter);
            }
        }
    }
}
