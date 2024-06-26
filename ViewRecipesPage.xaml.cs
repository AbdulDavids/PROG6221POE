using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace RecipeManagerApp
{
    public partial class ViewRecipesPage : Page
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ViewRecipesPage()
        {
            InitializeComponent();
            Recipes = LoadRecipes();
            DataContext = this; // Ensure the DataContext is set to the current instance
        }

        private ObservableCollection<Recipe> LoadRecipes()
        {
            return new ObservableCollection<Recipe>
            {
                new Recipe
                {
                    Name = "Chocolate Chip Cookies",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Sugar", Quantity = 100, Unit = "grams", Calories = 387, FoodGroup = "Carbohydrates" },
                        new Ingredient { Name = "Chocolate Chips", Quantity = 200, Unit = "grams", Calories = 535, FoodGroup = "Fats" }
                    },
                    Steps = new ObservableCollection<string> { "Mix ingredients", "Bake at 350 degrees" }
                },
                new Recipe
                {
                    Name = "Pancakes",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Flour", Quantity = 500, Unit = "grams", Calories = 1820, FoodGroup = "Carbohydrates" },
                        new Ingredient { Name = "Eggs", Quantity = 3, Unit = "pieces", Calories = 240, FoodGroup = "Protein" }
                    },
                    Steps = new ObservableCollection<string> { "Mix ingredients", "Fry on pan" }
                }
            };
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = (sender as FrameworkElement).DataContext as Recipe;
            if (recipe != null)
            {
                DetailedRecipeView view = new DetailedRecipeView(recipe);
                view.Show();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = (sender as FrameworkElement).DataContext as Recipe;
            if (recipe != null)
            {
                Recipes.Remove(recipe);
            }
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe = (sender as FrameworkElement).DataContext as Recipe;
            if (recipe != null)
            {
                ScaleRecipeDialog scaleDialog = new ScaleRecipeDialog();
                if (scaleDialog.ShowDialog() == true)
                {
                    recipe.Scale(scaleDialog.ScalingFactor);
                }
            }
        }
    }
}
