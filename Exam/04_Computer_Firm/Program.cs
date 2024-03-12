using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double totalSales = 0;
        double totalRating = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            int rating = input % 10;
            int sales = input / 10;

            switch (rating)
            {
                case 2:
                    totalSales += 0;
                    break;
                case 3:
                    totalSales += sales * 0.5;
                    break;
                case 4:
                    totalSales += sales * 0.7;
                    break;
                case 5:
                    totalSales += sales * 0.85;
                    break;
                case 6:
                    totalSales += sales;
                    break;
            }

            totalRating += rating;
        }

        Console.WriteLine($"{totalSales:F2}");
        Console.WriteLine($"{totalRating / n:F2}");
    }
}