using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int num = int.Parse(Console.ReadLine());

            int digit1 = num % 10;  // Единици
            num /= 10;
            int digit2 = num % 10;  // Десетици
            num /= 10;
            int digit3 = num;       // Стотици

            // Генериране на таблицата за умножение
            for (int i = 1; i <= digit1; i++)
            {
                for (int j = 1; j <= digit2; j++)
                {
                    for (int k = 1; k <= digit3; k++)
                    {
                        int product = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {product};");
                    }
                }
            }
        }
    }
}
