using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. One-dimensional array of strings
        string[] phrases = { "Hello", "Goodbye", "Welcome", "Thanks" };

        // 2. A list with unique items (used for exact search)
        List<string> uniqueList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };

        // 3. A list with duplicate items (used for multiple match search)
        List<string> duplicateList = new List<string> { "Apple", "Banana", "Cherry", "Banana", "Fig", "Apple" };

        // 4. A list with duplicate items (used for foreach duplicate check)
        List<string> checkForDuplicatesList = new List<string> { "A", "B", "C", "D", "C", "A", "E" };

        // Infinite loop to keep the app running until user types 'exit'
        while (true)
        {
            Console.Write("Please enter text to append to each phrase (or type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
                break;

            // Loop using "<" operator to modify array
            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] += " " + userInput;
            }

            // Loop using "<=" operator to print updated array
            Console.WriteLine("\nUpdated phrases:");
            for (int j = 0; j <= phrases.Length - 1; j++)
            {
                Console.WriteLine($"Index {j}: {phrases[j]}");
            }

            // Search in unique list — single match
            Console.Write("\nSearch unique list — enter a word: ");
            string searchUnique = Console.ReadLine();
            bool uniqueFound = false;

            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i].ToLower() == searchUnique.ToLower())
                {
                    Console.WriteLine($"Found in unique list at index {i}: {uniqueList[i]}");
                    uniqueFound = true;
                    break;
                }
            }

            if (!uniqueFound)
            {
                Console.WriteLine("That item is not in the unique list.");
            }

            // Search in duplicate list — all matches
            Console.Write("\nSearch duplicate list — enter a word: ");
            string searchDuplicate = Console.ReadLine();
            bool duplicateFound = false;

            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i].ToLower() == searchDuplicate.ToLower())
                {
                    Console.WriteLine($"Match found in duplicate list at index {i}: {duplicateList[i]}");
                    duplicateFound = true;
                }
            }

            if (!duplicateFound)
            {
                Console.WriteLine("That item is not in the duplicate list.");
            }

            // ✅ NEW SECTION: Foreach loop to check for duplicates in a list
            Console.WriteLine("\nDuplicate check in custom list:\n");

            // HashSet to track which items we've seen already
            HashSet<string> seenItems = new HashSet<string>();

            // Foreach loop through the duplicate-check list
            foreach (string item in checkForDuplicatesList)
            {
                if (seenItems.Contains(item))
                {
                    // If already seen, it's a duplicate
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    // If not seen, it's unique
                    Console.WriteLine($"{item} - this item is unique");
                    seenItems.Add(item); // Track it
                }
            }

            Console.WriteLine("\n-------------------------\n");
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey(); // Wait for user to press a key before closing
    }
}

