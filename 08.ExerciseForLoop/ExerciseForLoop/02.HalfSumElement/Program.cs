using System;
using System.Collections.Generic;

namespace SumEqualsOtherElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
               
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            int sumWithoutMAx = sum - max;
            if (sumWithoutMAx == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMAx)}");
            }
        }
    }
}
