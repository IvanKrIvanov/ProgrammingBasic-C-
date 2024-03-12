using System;

class Program
{
    static void Main()
    {
        int target = int.Parse(Console.ReadLine());
        double earnedMoney = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "closed")
            {
                break;
            }

            switch (input)
            {
                case "haircut":
                    string haircutType = Console.ReadLine();

                    switch (haircutType)
                    {
                        case "mens":
                            earnedMoney += 15;
                            break;
                        case "ladies":
                            earnedMoney += 20;
                            break;
                        case "kids":
                            earnedMoney += 10;
                            break;
                    }

                    break;
                case "color":
                    string colorType = Console.ReadLine();

                    switch (colorType)
                    {
                        case "touch up":
                            earnedMoney += 20;
                            break;
                        case "full color":
                            earnedMoney += 30;
                            break;
                    }

                    break;
            }

            if (earnedMoney >= target)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {earnedMoney}lv.");
                return;
            }
        }

        double moneyNeeded = target - earnedMoney;
        Console.WriteLine($"Target not reached! You need {moneyNeeded}lv. more.");
        Console.WriteLine($"Earned money: {earnedMoney}lv.");
    }
}