using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (filmName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int currentTickets = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    currentTickets++;

                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }

                    if (currentTickets >= freeSeats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                double percentageFull = (double)currentTickets / freeSeats * 100;
                Console.WriteLine($"{filmName} - {percentageFull:F2}% full.");
                totalTickets += currentTickets;

                filmName = Console.ReadLine();
            }

            double percentageStudent = (double)studentTickets / totalTickets * 100;
            double percentageStandard = (double)standardTickets / totalTickets * 100;
            double percentageKid = (double)kidTickets / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentageStudent:F2}% student tickets.");
            Console.WriteLine($"{percentageStandard:F2}% standard tickets.");
            Console.WriteLine($"{percentageKid:F2}% kids tickets.");
        }
    }
}
