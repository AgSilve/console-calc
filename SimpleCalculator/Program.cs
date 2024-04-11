Console.WriteLine("Let's do simple addition!");

/*As of now, the program is set up to do arithmetic operation between two numbers entered by the user.
*/

Console.WriteLine("Enter the first number:");
string? firstNumberInput = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string? secondNumberInput = Console.ReadLine();

int? firstNumber = null, secondNumber = null;

if (firstNumberInput != null)
{
    firstNumber = int.Parse(firstNumberInput);
}

if (secondNumberInput != null)
{
    secondNumber = int.Parse(secondNumberInput);
}

if (firstNumber != null && secondNumber != null)
{
    int sum = firstNumber.Value + secondNumber.Value;
    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
}
else 
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}