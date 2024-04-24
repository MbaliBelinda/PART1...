using System;

class Recipe
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Recipe Manager!");

        // Get recipe details from the user
        Console.WriteLine("Enter the number of ingredients:");
        int numIngredients = Convert.ToInt32(Console.ReadLine());

        string[] ingredients = new string[numIngredients];
        double[] quantities = new double[numIngredients];
        string[] units = new string[numIngredients];

        // Input ingredients
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"Enter ingredient #{i + 1} name:");
            ingredients[i] = Console.ReadLine();

            Console.WriteLine($"Enter quantity of {ingredients[i]}:");
            quantities[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter unit of measurement for {ingredients[i]}:");
            units[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the number of steps:");
        int numSteps = Convert.ToInt32(Console.ReadLine());

        string[] steps = new string[numSteps];

        // Input steps
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter step #{i + 1}:");
            steps[i] = Console.ReadLine();
        }

        // Display the full recipe
        Console.WriteLine("\nFull Recipe:");
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }

        // Scaling the recipe
        Console.WriteLine("\nEnter scaling factor (0.5, 2, or 3):");
        double scaleFactor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nScaled Recipe (Factor: {scaleFactor}):");
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < numIngredients; i++)
        {
            double scaledQuantity = quantities[i] * scaleFactor;
            Console.WriteLine($"{scaledQuantity} {units[i]} of {ingredients[i]}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }

        // Reset quantities
        Console.WriteLine("\nDo you want to reset quantities to original values? (yes/no)");
        string resetChoice = Console.ReadLine();
        if (resetChoice.ToLower() == "yes")
        {
            Console.WriteLine("\nOriginal Recipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
            }
        }

        // Clear data
        Console.WriteLine("\nDo you want to clear all data and enter a new recipe? (yes/no)");
        string clearChoice = Console.ReadLine();
        if (clearChoice.ToLower() == "yes")
        {
            Console.Clear(); // Clear console screen
            Main(args); // Restart the program
        }
    }
}