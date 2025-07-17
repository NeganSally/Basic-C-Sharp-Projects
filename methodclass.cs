using System; // Importing the System namespace for basic functionality like Console

// Define a class named MathHandler
class MathHandler
{
    // This is a void method that takes two integers as parameters
    public void Operate(int num1, int num2)
    {
        // Perform a math operation on the first integer (e.g., multiply by 2)
        int result = num1 * 2;

        // Display the result of the math operation
        Console.WriteLine("Result of num1 * 2 is: " + result);

        // Display the second integer as requested
        Console.WriteLine("Second number passed in: " + num2);
    }
}

// This is the entry point of the console application
class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathHandler class (create an object of the class)
        MathHandler handler = new MathHandler();

        // Call the Operate method using positional arguments (order matters)
        handler.Operate(5, 10); // 5 will be num1, 10 will be num2

        // Call the Operate method using named arguments (order doesn't matter)
        handler.Operate(num2: 20, num1: 3); // num1 is 3, num2 is 20
    }
}
