using System;

namespace _01.OldBooks2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bookToForLook = Console.ReadLine();
            int checkedBooksCount = 0;
            string inputBook = Console.ReadLine();
            bool bookIsFound = false;   
            while (inputBook != "No More Books")
            {
                if (inputBook == bookToForLook)
                {
                    bookIsFound = true;
                    break;
                }
                checkedBooksCount++;
                inputBook = Console.ReadLine();

            }
            if (bookIsFound)
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
