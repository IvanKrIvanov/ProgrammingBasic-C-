using System;

namespace ActorPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double totalPoints = initialPoints;

            for (int i = 0; i < n; i++)
            {
                string evaluatorName = Console.ReadLine();
                double evaluatorPoints = double.Parse(Console.ReadLine());

                double pointsToAdd = evaluatorName.Length * evaluatorPoints / 2;
                totalPoints += pointsToAdd;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
                    return;
                }
            }

            double neededPoints = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {actorName} you need {neededPoints:F1} more!");
        }
    }
}
