using NUnit.Framework;
using PROG6221POE; 

namespace PROG6221POETests
{

    // Reference: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
    // Reference: https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices

    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void TotalCalories_CalculatesCorrectly()
        {
            // Arrange
            var recipe = new Recipe("Test Recipe");
            recipe.AddIngredient(new Ingredient("Sugar", 100, "grams", 387, "Carbohydrates"));
            recipe.AddIngredient(new Ingredient("Butter", 50, "grams", 717, "Fats"));

            // Expected calories are calculated manually here for clarity:
            int expectedCalories = 100 * 387 + 50 * 717;

            // Act
            int totalCalories = recipe.TotalCalories();

            // Assert
            Assert.Equals(expectedCalories, totalCalories);
        }
    }
}
//--------------------------------------------------------------------------------------------------------------------