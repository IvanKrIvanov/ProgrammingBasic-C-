using System;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        int volume = length * width * height;
        double totalLiters = volume * 0.001;
        double occupiedLiters = totalLiters * (1 - (percent / 100));

        Console.WriteLine($"{occupiedLiters:F3}");
    }
}
