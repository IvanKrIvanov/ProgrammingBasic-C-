using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();

        string category = GetCategory(product);

        Console.WriteLine(category);
    }

    static string GetCategory(string product)
    {
        switch (product)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes":
                return "fruit";

            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                return "vegetable";

            default:
                return "unknown";
        }
    }
}
