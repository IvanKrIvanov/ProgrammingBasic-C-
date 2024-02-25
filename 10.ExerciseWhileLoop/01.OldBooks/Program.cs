using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToForLook = Console.ReadLine();
            int checkedBooksCount = 0;
            string inputBook = Console.ReadLine();
            while (inputBook != "No More Books")
            {
                if (inputBook == bookToForLook)
                {
                    break;
                }
                checkedBooksCount++;
                inputBook = Console.ReadLine();

            }
            if (inputBook == bookToForLook)
            {
                Console.WriteLine($"You checked {checkedBooksCount} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }
        }
    }
}
