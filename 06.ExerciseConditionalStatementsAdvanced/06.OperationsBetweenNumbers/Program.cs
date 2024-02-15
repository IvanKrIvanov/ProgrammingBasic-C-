using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());

        double result = 0;
        bool isEven = false;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                isEven = (result % 2 == 0);
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, op, num2, result, isEven ? "even" : "odd");
                break;
            case '-':
                result = num1 - num2;
                isEven = (result % 2 == 0);
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, op, num2, result, isEven ? "even" : "odd");
                break;
            case '*':
                result = num1 * num2;
                isEven = (result % 2 == 0);
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, op, num2, result, isEven ? "even" : "odd");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = (double)num1 / num2;
                    Console.WriteLine("{0} {1} {2} = {3:F2}", num1, op, num2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                break;
            case '%':
                if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
