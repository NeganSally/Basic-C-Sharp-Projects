using System;

class Program
{
    static void Main()
    {
        // 1. Multiply input by 50
        Console.WriteLine("Enter a number to multiply by 50:");
        string input1 = Console.ReadLine();                 // Read user input as string
        long num1 = Convert.ToInt64(input1);                // Convert to long for large numbers (>10 million)
        long result1 = num1 * 50;                           // Multiply by 50
        Console.WriteLine("Result: " + result1);            // Output the result

        // 2. Add 25 to input
        Console.WriteLine("Enter a number to add 25 to:");
        string input2 = Console.ReadLine();                 // Read input
        int num2 = Convert.ToInt32(input2);                 // Convert to int
        int result2 = num2 + 25;                            // Add 25
        Console.WriteLine("Result: " + result2);            // Output the result

        // 3. Divide input by 12.5
        Console.WriteLine("Enter a number to divide by 12.5:");
        string input3 = Console.ReadLine();                 // Read input
        double num3 = Convert.ToDouble(input3);             // Convert to double for decimal division
        double result3 = num3 / 12.5;                        // Divide by 12.5
        Console.WriteLine("Result: " + result3);            // Output the result

        // 4. Check if input is greater than 50
        Console.WriteLine("Enter a number to check if it is greater than 50:");
        string input4 = Console.ReadLine();                 // Read input
        int num4 = Convert.ToInt32(input4);                 // Convert to int
        bool isGreaterThan50 = num4 > 50;                   // Check if greater than 50
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50); // Output result

        // 5. Get remainder after dividing by 7
        Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
        string input5 = Console.ReadLine();                 // Read input
        int num5 = Convert.ToInt32(input5);                 // Convert to int
        int remainder = num5 % 7;                           // Use modulus operator to get remainder
        Console.WriteLine("Remainder: " + remainder);       // Output remainder
    }
}
