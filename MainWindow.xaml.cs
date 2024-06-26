using System.Windows;

namespace RecipeManagerApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddRecipePage());
        }

        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new ViewRecipesPage());
        }
        private void NavigateToFilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            FilterRecipesPage filterPage = new FilterRecipesPage();
            MainContent.Navigate(filterPage);
        }

    }
}
