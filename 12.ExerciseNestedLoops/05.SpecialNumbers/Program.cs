using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1111; num <= 9999; num++)
            {
                bool isSpecial = true;
                int currentNum = num;

                while (currentNum > 0)
                {
                    int digit = currentNum % 10;
                    currentNum /= 10;

                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
