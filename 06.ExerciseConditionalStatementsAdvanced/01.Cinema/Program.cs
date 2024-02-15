using System;

class Program
{
    static void Main()
    {

        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        int totalSeats = rows * columns;
        double totalRevenue = 0.0;

        if (projectionType == "Premiere")
        {
            double ticketPrice = 12.00;
            totalRevenue = ticketPrice * totalSeats;
        }
        else if (projectionType == "Normal")
        {
            double ticketPrice = 7.50;
            totalRevenue = ticketPrice * totalSeats;
        }
        else if (projectionType == "Discount")
        {
            double ticketPrice = 5.00;
            totalRevenue = ticketPrice * totalSeats;
        }

        Console.WriteLine("{0:F2} leva", totalRevenue);
    }
}
