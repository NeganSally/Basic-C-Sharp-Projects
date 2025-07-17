using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list of integers
        List<int> list = new List<int>() { 5, 3, 102, 88, 91, 52, 41, 22, 1234, 99990 };

        // Ask user for input and loop through the list dividing each number by the input
        bool numValid = false;
        while (!numValid) // ✅ condition
        {
            try
            {
                Console.WriteLine("\nEnter a number to divide the list by: ");
                float numDivide = float.Parse(Console.ReadLine());

                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                else
                {
                    foreach (int num in list) //  list name
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine($"{num} / {numDivide} = {Divide}");
                    }
                    numValid = true; //Ends loop after successful run
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("The program has exited the try/catch block.");
    }
}
