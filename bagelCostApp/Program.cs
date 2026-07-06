using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask the user
        Console.WriteLine("How many bagels would you like to order?");

        // Step 2: Get, handle null, and convert input
        int bagels = int.Parse(Console.ReadLine() ?? "0");

        // Step 3: Check for invalid input
        if (bagels <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number of bagels.");
            return;
        }

        // Step 4: Calculate the cost
        double totalCost;

        if (bagels >= 6)
        {
            totalCost = bagels * 0.60; // 60c each for half dozen or more
        }
        else
        {
            totalCost = bagels * 0.75; // 75c each for less than half dozen
        }

        // Step 5: Display the result
        Console.WriteLine("You ordered " + bagels + " bagels.");
        Console.WriteLine("Total cost: R" + totalCost);
    }
}
