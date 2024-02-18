using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstNumbers = new int[n];
        int[] secondNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {

            firstNumbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {

            secondNumbers[i] = int.Parse(Console.ReadLine());
        }

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            leftSum += firstNumbers[i];
            rightSum += secondNumbers[i];
        }

        int diff = Math.Abs(leftSum - rightSum);

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = " + leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = " + diff);
        }
    }
}