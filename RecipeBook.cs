﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class RecipeBook
    {
        public List<Recipe> Recipes { get; private set; }

        public RecipeBook()
        {
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
            Recipes.Sort((r1, r2) => r1.Name.CompareTo(r2.Name));
        }

        public void DisplayAllRecipes()
        {
            foreach (Recipe recipe in Recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

        public Recipe GetRecipe(string name)
        {
            return Recipes.FirstOrDefault(recipe => recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

}
