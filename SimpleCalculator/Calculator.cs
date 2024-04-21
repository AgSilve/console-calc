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

    }
}