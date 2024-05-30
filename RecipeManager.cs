using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class RecipeManager
    {
        public RecipeBook recipeBook;
        public Recipe currentRecipe;

        public RecipeManager()
        {
            recipeBook = new RecipeBook();
            currentRecipe = null;
        }

        public void CreateRecipe()  // Create a new recipe
        {
            Console.WriteLine("Enter recipe name:");
            string name = Console.ReadLine();
            Recipe recipe = new Recipe(name);

            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter ingredient {i + 1} name:");
                string ingredientName = Console.ReadLine();

                Console.WriteLine($"Enter ingredient {i + 1} quantity:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter ingredient {i + 1} unit of measurement (e.g., tablespoon):");
                string unit = Console.ReadLine();

                Console.WriteLine($"Enter calories for {ingredientName}:");
                int calories = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter food group for {ingredientName}:");
                string foodGroup = Console.ReadLine();

                Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
                recipe.AddIngredient(ingredient);
            }

            Console.WriteLine("Enter the number of steps:");
            int stepCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1} description:");
                string step = Console.ReadLine();
                recipe.AddStep(step);
            }

            recipeBook.AddRecipe(recipe);
            currentRecipe = recipe;
        }

        public void DisplayRecipe(string name)
        {
            Recipe recipe = recipeBook.GetRecipe(name);
            recipe?.DisplayRecipe();
        }

        public void ScaleRecipe()  // Scale the current recipe quantities
        {
            if (currentRecipe == null)
            {
                Console.WriteLine("No current recipe to scale.");
                return;
            }

            Console.WriteLine("Enter scale factor (0.5 for half, 2 for double, 3 for triple):");
            double scaleFactor = double.Parse(Console.ReadLine());
            currentRecipe.ScaleRecipe(scaleFactor);
            currentRecipe.DisplayRecipe();
        }

        public void ResetRecipe()   // Reset the current recipe quantities
        {
            if (currentRecipe == null)
            {
                Console.WriteLine("No current recipe to reset.");
                return;
            }

            currentRecipe.ResetQuantities();
            currentRecipe.DisplayRecipe();
        }

        public void ClearRecipe()   // Clear the current recipe data
        {
            currentRecipe = null;
            Console.WriteLine("Current recipe data has been cleared.");
        }

        public void DisplayAllRecipes() // Display all recipes in the recipe book
        {
            recipeBook.DisplayAllRecipes();
        }

        // Method to retrieve a recipe by name
        public Recipe GetRecipe(string name)
        {
            return recipeBook.GetRecipe(name);
        }
    }
}