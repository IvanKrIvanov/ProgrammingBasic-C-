using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        double spentAmount = 0.0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                spentAmount = budget * 0.3;
            }
            else if (season == "winter")
            {
                spentAmount = budget * 0.7;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                spentAmount = budget * 0.4;
            }
            else if (season == "winter")
            {
                spentAmount = budget * 0.8;
            }
        }
        else
        {
            destination = "Europe";
            spentAmount = budget * 0.9;
        }

        string accommodation = "";

        if (destination == "Bulgaria" || destination == "Balkans")
        {
            if (season == "summer")
            {
                accommodation = "Camp";
            }
            else if (season == "winter")
            {
                accommodation = "Hotel";
            }
        }
        else if (destination == "Europe")
        {
            accommodation = "Hotel";
        }

        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:F2}", accommodation, spentAmount);
    }
}
