using System;

class Program
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        int ticketPrice = GetTicketPrice(dayOfWeek);

        if (ticketPrice != -1)
        {
            Console.WriteLine(ticketPrice);
        }
        else
        {
            Console.WriteLine("Invalid day of the week.");
        }
    }

    static int GetTicketPrice(string dayOfWeek)
    {
        switch (dayOfWeek.ToLower())
        {
            case "monday":
            case "tuesday":
            case "friday":
                return 12;

            case "wednesday":
            case "thursday":
                return 14;

            case "saturday":
            case "sunday":
                return 16;

            default:
                return -1;
        }
    }
}
