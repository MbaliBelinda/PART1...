# RecipeApp1
LINE BY LINE EXPLANATION OF MY CODE 

1. **Welcome Message**:

   Console.WriteLine("Welcome to Recipe Manager!");

   This line prints a welcome message to the console when the program starts.

2. **Getting Recipe Details**:
   
   Console.WriteLine("Enter the number of ingredients:");
   int numIngredients = Convert.ToInt32(Console.ReadLine());

   These lines prompt the user to input the number of ingredients for the recipe and store the value in `numIngredients`.

   
   string[] ingredients = new string[numIngredients];
   double[] quantities = new double[numIngredients];
   string[] units = new string[numIngredients];
  
   Arrays are initialized to store the names, quantities, and units of measurement for each ingredient. The size of these arrays is determined by the number of ingredients entered by the user.

3. **Inputting Ingredients**:
   
   for (int i = 0; i < numIngredients; i++)
   {
       Console.WriteLine($"Enter ingredient #{i + 1} name:");
       ingredients[i] = Console.ReadLine();

       Console.WriteLine($"Enter quantity of {ingredients[i]}:");
       quantities[i] = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine($"Enter unit of measurement for {ingredients[i]}:");
       units[i] = Console.ReadLine();
   }
 
   This loop iterates over each ingredient, prompting the user to input its name, quantity, and unit of measurement. The inputs are then stored in the respective arrays.

4. **Inputting Steps**:

   Console.WriteLine("Enter the number of steps:");
   int numSteps = Convert.ToInt32(Console.ReadLine());
   
   Similar to the ingredients, the program prompts the user to input the number of steps in the recipe and stores the input as an integer.

  
   string[] steps = new string[numSteps];

   An array named `steps` is initialized to store the steps of the recipe, with its size determined by the number of steps entered by the user.

 
   for (int i = 0; i < numSteps; i++)
   {
       Console.WriteLine($"Enter step #{i + 1}:");
       steps[i] = Console.ReadLine();
   }
   
   This loop prompts the user to input each step of the recipe, storing them in the `steps` array.

5. **Displaying the Recipe**:

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
  
   After collecting all the details, the program displays the full recipe, including ingredients and steps, in a neat format.

6. **Scaling the Recipe**:
 
   Console.WriteLine("\nEnter scaling factor (0.5, 2, or 3):");
   double scaleFactor = Convert.ToDouble(Console.ReadLine());

   The user is prompted to enter a scaling factor to scale the recipe up or down.

  
   double scaledQuantity = quantities[i] * scaleFactor;
  
   The quantities of each ingredient are then scaled according to the provided factor.

7. **Resetting Quantities and Clearing Data**:
   The program allows the user to reset quantities to their original values and to clear all data to enter a new recipe, as per user choice.

That's a comprehensive breakdown of each part of your code! Let me know if you have any questions or if you'd like to add any specific functionalities.# PART1
