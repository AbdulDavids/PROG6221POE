using System.Windows.Input;
using System.Collections.ObjectModel;

namespace RecipeManagerApp
{
    public class RecipeViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ScaleCommand { get; set; }

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            DeleteCommand = new RelayCommand(DeleteRecipe);
            ScaleCommand = new RelayCommand(ScaleRecipe);
        }

        private void DeleteRecipe(object parameter)
        {
            if (parameter is Recipe recipe)
            {
                Recipes.Remove(recipe);
            }
        }

        private void ScaleRecipe(object parameter)
        {
            if (parameter is Recipe recipe)
            {
                var dialog = new ScaleRecipeDialog();
                if (dialog.ShowDialog() == true)
                {
                    recipe.Scale(dialog.ScalingFactor);
                }
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
