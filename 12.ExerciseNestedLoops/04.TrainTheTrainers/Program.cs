using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double totalSum = 0;
            int presentationsCount = 0;

            while (presentationName != "Finish")
            {
                double presentationSum = 0;

                for (int i = 0; i < juryMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    presentationSum += grade;
                }

                double averageGrade = presentationSum / juryMembers;
                totalSum += averageGrade;
                presentationsCount++;

                Console.WriteLine($"{presentationName} - {averageGrade:F2}.");
                presentationName = Console.ReadLine();
            }

            double finalAssessment = totalSum / presentationsCount;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}
