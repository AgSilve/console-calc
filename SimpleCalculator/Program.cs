Console.WriteLine("Let's do simple arithmetic!");

/*As of now, the program is set up to do arithmetic operation between two numbers entered by the user.
*/

string[] operations = {"Addition", "Subtraction"} ;

Console.WriteLine("What action would you like to take? Would you like to add or subtract?");
string? userInputOperation = Console.ReadLine();
if (userInputOperation == "add" || userInputOperation =="Add")
{
    Console.WriteLine("Enter the first number:");
string? firstNumberInput = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string? secondNumberInput = Console.ReadLine();

int firstNumber, secondNumber;

if (int.TryParse(firstNumberInput, out firstNumber) && int.TryParse(secondNumberInput, out secondNumber))
    {
    int sum = firstNumber + secondNumber;
    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
    }
else
    {
    Console.WriteLine("Invalid input!");
    }
}
else if (userInputOperation == null)
{
    Console.WriteLine("Invalid input!");
}
else if (userInputOperation == "subtract" || userInputOperation =="Subtract" || userInputOperation == "sub" || userInputOperation == "Sub")
{
     Console.WriteLine("Enter the first number:");
string? firstNumberInput = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string? secondNumberInput = Console.ReadLine();

int firstNumber, secondNumber;

if (int.TryParse(firstNumberInput, out firstNumber) && int.TryParse(secondNumberInput, out secondNumber))
    {
    int difference = firstNumber - secondNumber;
    Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is: {difference}");
    }
else
    {
    Console.WriteLine("Invalid input!");
    }
}