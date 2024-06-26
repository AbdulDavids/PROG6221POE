using System.Windows;

namespace RecipeManagerApp
{
    public partial class DetailedRecipeView : Window
    {
        public Recipe CurrentRecipe { get; set; }

        public DetailedRecipeView(Recipe recipe)
        {
            InitializeComponent();
            CurrentRecipe = recipe ?? new Recipe();  // Ensure the recipe is initialized
            this.DataContext = CurrentRecipe;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            App.RecipeManager.Recipes.Remove(CurrentRecipe);
            this.Close();
        }

        private void Scale_Click(object sender, RoutedEventArgs e)
        {
            var scaleDialog = new ScaleRecipeDialog();
            if (scaleDialog.ShowDialog() == true)
            {
                CurrentRecipe.Scale(scaleDialog.ScalingFactor);
            }
        }
    }
}
