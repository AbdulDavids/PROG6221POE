using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace RecipeManagerApp
{
    public partial class FilterRecipesPage : Page
    {
        private ObservableCollection<Recipe> AllRecipes { get; set; }

        public FilterRecipesPage()
        {
            InitializeComponent();
            AllRecipes = App.RecipeManager.Recipes; // Assuming App.RecipeManager.Recipes contains all recipes
        }

        private void ApplyFilters_Click(object sender, RoutedEventArgs e)
        {
            var filteredRecipes = new ObservableCollection<Recipe>(AllRecipes);

            // Filter by ingredient name
            if (!string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
            {
                filteredRecipes = new ObservableCollection<Recipe>(filteredRecipes.Where(recipe =>
                    recipe.Ingredients.Any(ingredient =>
                        ingredient.Name.Contains(IngredientNameTextBox.Text, StringComparison.OrdinalIgnoreCase))));
            }

            // Filter by food group
            if (FoodGroupComboBox.SelectedItem != null)
            {
                var selectedFoodGroup = (FoodGroupComboBox.SelectedItem as ComboBoxItem).Content.ToString();
                filteredRecipes = new ObservableCollection<Recipe>(filteredRecipes.Where(recipe =>
                    recipe.Ingredients.Any(ingredient =>
                        ingredient.FoodGroup.Equals(selectedFoodGroup, StringComparison.OrdinalIgnoreCase))));
            }

            // Filter by maximum calories
            if (!string.IsNullOrWhiteSpace(MaxCaloriesTextBox.Text) && int.TryParse(MaxCaloriesTextBox.Text, out int maxCalories))
            {
                filteredRecipes = new ObservableCollection<Recipe>(filteredRecipes.Where(recipe =>
                    recipe.Ingredients.Sum(ingredient => ingredient.Calories) <= maxCalories));
            }

            FilteredRecipesListView.ItemsSource = filteredRecipes;
        }
    }
}
