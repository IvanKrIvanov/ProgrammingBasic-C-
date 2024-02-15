using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = int.Parse(Console.ReadLine());
            int arrivalTime = int.Parse(Console.ReadLine());

            int diff = examTime - arrivalTime;
            string verdict = "";
            string keyword = "";
            if (diff < 0) 
            { 
                verdict = "Late";
                keyword = "after";
            
            }
            else 
            {
                if (diff <= 30) { verdict = "On time"; }
            else { verdict = "Early"; }

            
            if (diff < 0) { keyword = "after"; }
            else { keyword = "before"; }

            string formattedTime = "";
            int absoluteDiff = Math.Abs(diff);

            if (absoluteDiff < 60)
            {
                formattedTime = $"{absoluteDiff} minutes";
            }
            else
            {
                int diffHours = absoluteDiff / 60;
                int diffMinutes = absoluteDiff % 60;

                if (diffMinutes < 10)
                {
                    formattedTime = $"{diffHours}:0{diffMinutes} hours";
                }
                else
                {
                    formattedTime = $"{diffHours}:{diffMinutes} hours";
                }
            }





            Console.WriteLine(verdict);
        }
    }
}
