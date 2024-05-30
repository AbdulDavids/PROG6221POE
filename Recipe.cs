using PROG6221POE;
using System.Collections.Generic;
using System;
using System.Linq;  
using PROG6221POE.Notifications;
using static PROG6221POE.Notifications.Notifications;

public class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<string> Steps { get; set; }

    public Recipe(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
        Steps = new List<string>();
    }
    //--------------------------------------------------------------------------------------------------------------------
    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }
    //--------------------------------------------------------------------------------------------------------------------
    public void AddStep(string step)
    {
        Steps.Add(step);
    }
    //--------------------------------------------------------------------------------------------------------------------
    public void DisplayRecipe()
    {
        Console.WriteLine($"Recipe: {Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }

        Console.WriteLine("\nSteps:");
        int stepNumber = 1;
        foreach (var step in Steps)
        {
            Console.WriteLine($"{stepNumber}. {step}");
            stepNumber++;
        }
    }
    //--------------------------------------------------------------------------------------------------------------------
    public int TotalCalories()
    {
        return Ingredients.Sum(ingredient => ingredient.Calories);
    }
    //--------------------------------------------------------------------------------------------------------------------
    public void CheckCalories(CalorieExceededNotification notification)
    {
        if (TotalCalories() > 300) // Check if total calories exceed 300
        {
            notification?.Invoke($"Warning: Total calories for {Name} exceed 300 calories!");
        }
    }
    //--------------------------------------------------------------------------------------------------------------------
    // New method to scale recipe quantities
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in Ingredients)
        {
            ingredient.Quantity *= factor;  // Scale each ingredient quantity
        }
    }
    //--------------------------------------------------------------------------------------------------------------------
    public void ResetQuantities()
    {
        foreach (var ingredient in Ingredients)
        {
            ingredient.Quantity = ingredient.OriginalQuantity;  // Reset to original quantity
        }
    }

}
//--------------------------------------------------------------------------------------------------------------------