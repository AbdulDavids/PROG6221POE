using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class RecipeManager
    {
        // Properties
        public Recipe currentRecipe;
        private List<Ingredient> originalIngredients;

        public RecipeManager()
        {
            currentRecipe = new Recipe();
            originalIngredients = new List<Ingredient>();
        }


        //--------------------------------------------------------------------------------
        // Methods

        // Create a new recipe
        public void CreateRecipe()
        {
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter ingredient {i + 1} name:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter ingredient {i + 1} quantity:");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter ingredient {i + 1} unit of measurement (e.g., tablespoon):");
                string unitOfMeasurement = Console.ReadLine();

                Ingredient ingredient = new Ingredient(name, quantity, unitOfMeasurement);
                currentRecipe.AddIngredient(ingredient);
                originalIngredients.Add(new Ingredient(name, quantity, unitOfMeasurement));
            }

            Console.WriteLine("Enter the number of steps:");
            int stepCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1} description:");
                string step = Console.ReadLine();
                currentRecipe.AddStep(step);
            }
        }

        // Scale the recipe
        public void ScaleRecipe()
        {
            Console.WriteLine("Enter scale factor (0.5 for half, 2 for double, 3 for triple):");
            double scaleFactor = Convert.ToDouble(Console.ReadLine());
            currentRecipe.ScaleRecipe(scaleFactor);
            currentRecipe.DisplayRecipe();
        }

        // Reset the recipe
        public void ResetRecipe()
        {
            currentRecipe.ResetQuantities(originalIngredients);
            currentRecipe.DisplayRecipe();
        }


        // delete the recipe
        public void ClearRecipe()
        {
            currentRecipe = new Recipe();
            originalIngredients.Clear();
        }
    }

}
//--------------------------------------------------------------------------------
