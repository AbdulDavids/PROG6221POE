using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class Recipe
        //--------------------------------------------------------------------------------

    {
        // Properties
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        // Constructor
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }


        //--------------------------------------------------------------------------------
        // add ingredient to the list
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        // add step to the list
        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        // display the recipe to the console 
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }

            Console.WriteLine("\nSteps:");
            int stepNumber = 1;
            foreach (var step in Steps)
            {
                Console.WriteLine($"{stepNumber}. {step}");
                stepNumber++;
            }
        }


        // scale the recipe by a factor 
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // reset the quantities of the ingredients to the original values
        public void ResetQuantities(List<Ingredient> originalIngredients)
        {
            Ingredients = new List<Ingredient>(originalIngredients);
        }
    }

}
// --------------------------------------------------------------------------------