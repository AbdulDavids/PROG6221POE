using System.Collections.ObjectModel;

namespace RecipeManagerApp
{
    public class RecipeManager
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeManager()
        {
            Recipes = new ObservableCollection<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
    }
}
