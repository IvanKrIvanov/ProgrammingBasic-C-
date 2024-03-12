using System;

namespace SumOfPrimesAndNonPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {

                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }

                if (!int.TryParse(input, out int number))
                {

                    continue;
                }

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if (IsPrime(number))
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
