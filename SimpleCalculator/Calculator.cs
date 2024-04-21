using System;

// This program is designed to carry out simple arithmetic operations between two numbers.
public class Calculator
{ 
    public double Add(double num1, double num2)
    {
        return num1 + num2 ;
    }
    public double Sub(double num1, double num2)
    {
        return num1 - num2 ;
    }
    public double Mult(double num1, double num2)
    {
        return num1 * num2 ;
    }
    public double Div(double num1, double num2)
    {
        return num1 / num2 ;
    }
}

class ConsoleCalc
{
    static void Main(string[] args)
    {
        Calculator calc = new();

        Console.WriteLine("Enter first number:");
        string? firstInput = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string? secondInput = Console.ReadLine();

        double num1, num2;

        double.TryParse(firstInput, out num1);
        double.TryParse(secondInput, out num2);

        Console.WriteLine("Enter the operation (+, -, *, /):");
        string? operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+" :
            result = calc.Add(num1, num2);
            break;

            case "-" :
            result = calc.Sub(num1, num2);
            break;

            case "*" :
            result = calc.Mult(num1, num2);
            break; 
            
            case "/":
                if (num2 != 0) 
                {
                    result = calc.Div(num1, num2);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                    return;
                }
                break;

            default:
            Console.WriteLine("Invalid operation!");
            break;
        }

        Console.WriteLine($"Result: {result}");

    }
}