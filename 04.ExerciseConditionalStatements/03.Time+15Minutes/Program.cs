using System;

class Program
{
    static void Main()
    {
        Console.Write("");
        int hour = int.Parse(Console.ReadLine());

        Console.Write("");
        int minutes = int.Parse(Console.ReadLine());


        minutes += 15;


        if (minutes >= 60)
        {
            hour = (hour + 1) % 24;
            minutes -= 60;
        }

        Console.WriteLine("{0}:{1:D2}", hour, minutes);
    }
}
