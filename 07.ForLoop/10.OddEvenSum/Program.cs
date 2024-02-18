using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) 
                evenSum += numbers[i];
            else 
                oddSum += numbers[i];
        }

        int diff = Math.Abs(evenSum - oddSum);

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + evenSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = " + diff);
        }
    }
}
