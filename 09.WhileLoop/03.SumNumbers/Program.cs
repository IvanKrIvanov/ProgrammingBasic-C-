using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int targetSum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int number;

            while (true)
            {

                number = int.Parse(Console.ReadLine());

                currentSum += number;

                if (currentSum >= targetSum)
                {
                    break;
                }
            }

            Console.WriteLine(currentSum);
        }
    }
}
