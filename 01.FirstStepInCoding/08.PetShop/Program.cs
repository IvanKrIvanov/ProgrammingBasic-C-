using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDogPackaet = int.Parse(Console.ReadLine());
            int numberCatPackaet = int.Parse(Console.ReadLine());

            double finalPrice = (numberDogPackaet * 2.50) + (numberCatPackaet * 4.00);

            Console.WriteLine($"{finalPrice} lv.");




        }
    }
}
