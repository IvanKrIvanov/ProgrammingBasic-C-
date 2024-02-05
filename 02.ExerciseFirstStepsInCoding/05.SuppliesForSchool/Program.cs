using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            //double totalPensPrice = pens * 5.8;
            // double totalMarkersPrice = markers * 7.2;
            // double totalPreparationPrice = preparation * 1.2;
            double TotalPrice = pens * 5.8 + markers * 7.2 + preparation * 1.2;
            double totalPriceWithDiscount = TotalPrice - (TotalPrice * discountPercentage) * 0.01;
            Console.WriteLine(totalPriceWithDiscount);


        }
    }
}
