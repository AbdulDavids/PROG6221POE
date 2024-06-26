using System.Windows;

namespace RecipeManagerApp
{
    public partial class App : Application
    {
        public static RecipeManager RecipeManager { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RecipeManager = new RecipeManager(); // Initialize your RecipeManager here
        }
    }
}
