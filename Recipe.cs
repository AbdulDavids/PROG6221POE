using System.Collections.ObjectModel;
using System.Linq;

namespace RecipeManagerApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; set; }
        public ObservableCollection<string> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new ObservableCollection<Ingredient>();
            Steps = new ObservableCollection<string>();
        }

        public string IngredientsDisplay
        {
            get
            {
                return string.Join(", ", Ingredients.Select(i => $"{i.Name} ({i.Quantity} {i.Unit})"));
            }
        }

        public string StepsDisplay
        {
            get
            {
                return string.Join(", ", Steps);
            }
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
    }


}
