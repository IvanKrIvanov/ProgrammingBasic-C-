using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double result = depositSum + depositTerm * ((depositSum * interestRate * 0.01) / 12);
            Console.WriteLine(result);
        }
    }
}
