using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> history = new List<string>();
            string y_n = "";
            double num1 = 0, num2, result = 0;
            bool isoperation = true;

            do
            {
                if (isoperation)
                {
                    Console.WriteLine("first number=");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    isoperation = false;
                }
                else
                {
                    num1 = result;
                }

                Console.WriteLine(" the operator (+,-,*,/):");
                string operatorType = Console.ReadLine();

                Console.WriteLine("second number:");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operatorType)
                {
                    case "+":
                        result = num1 + num2;
                        history.Add($"{num1} {operatorType} {num2} = {result}");
                        Console.WriteLine($"Result: {result}");
                        break;
                     case "-":
                        result = num1 - num2;
                        history.Add($"{num1} {operatorType} {num2} = {result}");
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        history.Add($"{num1} {operatorType} {num2} = {result}");
                        Console.WriteLine($"Result: {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            history.Add($"{num1} {operatorType} {num2} = {result}");
                            Console.WriteLine($"Result: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error! Division by zero is not allowed.");
                        }
                        break;
                    default:Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine("continue with the previous result? (y/n)");
                y_n = Console.ReadLine();

            } while (y_n.ToLower() == "y");

            Console.WriteLine("\nOperation History:");
            foreach (var operation in history)
            {
                Console.WriteLine(operation);
            }
            Console.ReadLine();
        }
    }
}
