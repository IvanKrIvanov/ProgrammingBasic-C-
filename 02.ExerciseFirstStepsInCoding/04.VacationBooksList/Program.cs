using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sheetsCount = int.Parse(Console.ReadLine());   
            int sheetsPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = (sheetsCount / sheetsPerHour) / days;
            Console.WriteLine(hours);

        }
    }
}
