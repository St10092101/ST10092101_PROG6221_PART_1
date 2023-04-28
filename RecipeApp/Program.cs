using System;

namespace RecipeApp
{
    class Recipe
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;
        public Recipe()
        {

            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        public void EnterDetails()
        {

            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());


            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];


            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}:");
                Console.Write("Name: ");
                ingredients[i] = Console.ReadLine();
                Console.Write("Quantity: ");
                quantities[i] = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                units[i] = Console.ReadLine();
            }


            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());


            steps = new string[numSteps];


            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step #{i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }
        public void DisplayRecipe()
        {

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"- {quantities[i]} {units[i]} of {ingredients[i]}");
            }


            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"- {steps[i]}");
            }
        }
        public void ScaleRecipe(double factor)
        {

            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }
        }
        public void ResetQuantities()
        {

            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] /= 2;
            }
        }
        public void ClearRecipe()
        {

            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                Console.WriteLine("Enter '1' to enter recipe details");
                Console.WriteLine("Enter '2' to display recipe");
                Console.WriteLine("Enter '3' to scale recipe");
                Console.WriteLine("Enter '4' to reset quantities");
                Console.WriteLine("Enter '5' to clear recipe");
                Console.WriteLine("Enter '6' to exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        recipe.EnterDetails();
                        break;
                    case "2":
                        recipe.DisplayRecipe();
                        break;
                    case "3":
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        break;
                    case "4":
                        recipe.ResetQuantities();
                        break;
                    case "5":
                        recipe.ClearRecipe();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;
                }
            }
        }
    }
}