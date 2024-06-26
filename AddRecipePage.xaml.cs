using System.Windows;
using System.Windows.Controls;

namespace RecipeManagerApp
{
    public partial class AddRecipePage : Page
    {
        public Recipe CurrentRecipe { get; set; }

        public AddRecipePage()
        {
            InitializeComponent();
            CurrentRecipe = new Recipe();
            this.DataContext = CurrentRecipe;
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IngredientNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(QuantityTextBox.Text) ||
                UnitComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(CaloriesTextBox.Text) ||
                FoodGroupComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all ingredient fields.");
                return;
            }

            if (!double.TryParse(QuantityTextBox.Text, out double quantity) ||
                !int.TryParse(CaloriesTextBox.Text, out int calories))
            {
                MessageBox.Show("Please enter valid numeric values for quantity and calories.");
                return;
            }

            CurrentRecipe.Ingredients.Add(new Ingredient
            {
                Name = IngredientNameTextBox.Text,
                Quantity = quantity,
                Unit = (UnitComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                Calories = calories,
                FoodGroup = (FoodGroupComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
            });

            IngredientNameTextBox.Clear();
            QuantityTextBox.Clear();
            UnitComboBox.SelectedIndex = -1;
            CaloriesTextBox.Clear();
            FoodGroupComboBox.SelectedIndex = -1;
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StepTextBox.Text))
            {
                MessageBox.Show("Please enter a step.");
                return;
            }

            CurrentRecipe.Steps.Add(StepTextBox.Text);
            StepTextBox.Clear();
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecipeNameTextBox.Text))
            {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            CurrentRecipe.Name = RecipeNameTextBox.Text;

            // Assuming App.RecipeManager is a static instance managing the recipes
            App.RecipeManager.AddRecipe(CurrentRecipe);
            MessageBox.Show("Recipe saved!");

            CurrentRecipe = new Recipe();
            this.DataContext = CurrentRecipe;
            RecipeNameTextBox.Clear();
        }
    }
}
