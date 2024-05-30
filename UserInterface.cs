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

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                // Set the color for the menu titles
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nChoose an option:");
                Console.ResetColor();  // Reset to default color

                // Set menu options in a different color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Display all recipes");
                Console.WriteLine("7. Exit");
                Console.ResetColor();  // Reset to default color

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
                            recipe.CheckCalories(CalorieWarning);
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

        private void CalorieWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
