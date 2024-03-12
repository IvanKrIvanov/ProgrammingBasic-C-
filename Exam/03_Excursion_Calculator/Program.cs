using System;

namespace ExcursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int numberOfPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // Цени на екскурзиите
            double pricePerPerson = 0.0;

            if (season == "spring")
            {
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 50.00;
                }
                else
                {
                    pricePerPerson = 48.00;
                }
            }
            else if (season == "summer")
            {
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 48.50;
                }
                else
                {
                    pricePerPerson = 45.00;
                }
            }
            else if (season == "autumn")
            {
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 60.00;
                }
                else
                {
                    pricePerPerson = 49.50;
                }
            }
            else if (season == "winter")
            {
                if (numberOfPeople <= 5)
                {
                    pricePerPerson = 86.00;
                }
                else
                {
                    pricePerPerson = 85.00;
                }
            }

            // Промени цената според сезона
            if (season == "summer")
            {
                pricePerPerson *= 0.85; // 15% отстъпка
            }
            else if (season == "winter")
            {
                pricePerPerson *= 1.08; // 8% оскъпяване
            }

            // Изчисляване на общата цена
            double totalPrice = pricePerPerson * numberOfPeople;

            // Изход
            Console.WriteLine($"{totalPrice:F2} leva.");
        }
    }
}
