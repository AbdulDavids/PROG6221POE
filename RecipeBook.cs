using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class RecipeBook
    {
        public List<Recipe> Recipes { get; private set; }

        public RecipeBook()
        {
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
            // Sort the list each time a new recipe is added
            Recipes = Recipes.OrderBy(r => r.Name).ToList();
        }

        public void DisplayAllRecipes() // Display all recipes in the recipe book
        {
            foreach (Recipe recipe in Recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

        public Recipe GetRecipe(string name) // Get a recipe by name
        {
            return Recipes.FirstOrDefault(recipe => recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

}
