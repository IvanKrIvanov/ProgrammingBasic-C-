using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMacinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int savedMoney = 0;
            int giftMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    savedMoney += toyPrice;
                }
                else
                {
                    savedMoney += giftMoney - 1;
                    giftMoney += 10;
                }
            }
            if (savedMoney >= washingMacinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMacinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMacinePrice - savedMoney:f2}");
            }
        }
    }
}
