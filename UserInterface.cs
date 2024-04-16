using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class UserInterface
    {
        private RecipeManager recipeManager;

        // Constructor to initialize the RecipeManager object
        public UserInterface()
        {
            recipeManager = new RecipeManager();
        }

        // Start the user interface
        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                // Display the menu options
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Exit");
                string option = Console.ReadLine();

                // Switch statement to handle the user's choice
                switch (option)
                {
                    case "1":
                        recipeManager.CreateRecipe();
                        break;
                    case "2":
                        recipeManager.currentRecipe.DisplayRecipe();
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
                        exit = true;
                        break;
                    default:
                        // if user is being silly
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

}
//--------------------------------------------------------------------------------
