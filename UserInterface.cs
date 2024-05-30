using System;

namespace PROG6221POE
{
    public class UserInterface
    {
        private RecipeManager recipeManager;

        public UserInterface()
        {
            recipeManager = new RecipeManager();
        }

        private void CalorieWarning(string message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Display all recipes");
                Console.WriteLine("7. Exit");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        recipeManager.CreateRecipe();
                        break;
                    case "2":
                        Console.WriteLine("Enter the recipe name to display:");
                        string name = Console.ReadLine();
                        Recipe recipe = recipeManager.GetRecipe(name);
                        if (recipe != null)
                        {
                            recipe.DisplayRecipe();
                            recipe.CheckCalories(CalorieWarning);  // Delegate usage
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;
                    case "3":
                        recipeManager.ScaleRecipe();
                        break;
                    case "4":
                        recipeManager.ResetRecipe();
                        break;
                    case "5":
                        recipeManager.ClearRecipe();
                        break;
                    case "6":
                        recipeManager.DisplayAllRecipes();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
