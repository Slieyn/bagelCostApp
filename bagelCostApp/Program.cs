using System;

class BagelCostApp
{
    static void Main()
    {
        Console.Write("Enter the number of bagels ordered: ");

        int numBagels;
        while (!int.TryParse(Console.ReadLine(), out numBagels) || numBagels < 0)
        {
            Console.Write("Invalid input. Please enter a valid whole number of bagels: ");
        }

        int pricePerBagel;

        if (numBagels < 6)
        {
            pricePerBagel = 75;
        }
        else
        {
            pricePerBagel = 60;
        }

        int totalCost = numBagels * pricePerBagel;

        Console.WriteLine($"Number of bagels: {numBagels}");
        Console.WriteLine($"Price per bagel: {pricePerBagel} cents");
        Console.WriteLine($"Total cost: {totalCost} cents (${totalCost / 100.0:F2})");
    }
}