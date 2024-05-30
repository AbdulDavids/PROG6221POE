# PROG6221POE - ST10267411

Hi this is my PROG6221 project.

#### Project Overview

This Recipe Management App allows users to enter details of a cooking recipe, which includes ingredients and preparation steps. The application supports scaling the recipe quantities by different factors and provides functionality to reset or clear the recipe data.

#### Features

- **Enter Recipe Details**: Users can input the number of ingredients, their names, quantities, units of measurement, and detailed step-by-step instructions.
- **Display Recipe**: Users can view the complete recipe with all ingredients and steps listed neatly.
- **Scale Recipe**: The application allows the recipe to be scaled by factors of 0.5 (half), 2 (double), and 3 (triple).
- **Reset Recipe**: Users can reset the recipe quantities to the original amounts.
- **Clear Recipe**: This option clears all entered data, allowing for a new recipe to be inputted.

#### How to Setup

To set up this project, you will need to clone the GitHub repository to your local machine.

#### How to Compile and Run

The project is developed using C# with .NET Core. Make sure you have [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

1. **Open the Command Line (Windows) or Terminal (macOS & Linux).**
2. **Navigate to the project's root directory where the `.csproj` file is located.**
3. **Run the following command to build the project:**
   ```sh
   dotnet build
   ```
   This command compiles the code and creates an executable file in the `/bin/debug` folder.
4. **To run the application, execute:**
   ```sh
   dotnet run
   ```

#### Using the Application

- Upon running the application, you will be greeted with a menu prompting to choose an option for entering data, scaling recipe, resetting recipe, or clearing the recipe.
- Follow the prompts to enter ingredients and steps as requested.
- Choose the appropriate option from the menu to scale, reset, or clear the recipe as needed.

### Commits
![Screenshot 2024-04-16 180917](https://github.com/AbdulDavids/PROG6221POE/assets/125186956/4f25d317-d9a4-4a10-b2ee-07b39b0b603e)






### Changes implemented from feedback

In addressing the feedback from Part 1, I have made several enhancements to the application to improve functionality, user experience, and code quality. First, I ensured that each method and class references were clearly defined to maintain dependency integrity. For error handling, I implemented checks for null values and incorrect data types across user inputs, ensuring that the application gracefully handles errors and displays appropriate messages to guide users correctly.

To enhance the user interface, I incorporated colored text in the display menu, which not only makes the application more visually appealing but also improves readability and user interaction. Regarding the scaling feature, I ensured that units of measurement are accurately adjusted according to the scaling factor, thus maintaining the consistency and correctness of recipe details.

Additionally, I added a confirmation step before clearing data, which prevents accidental deletions and ensures that users are aware of their actions. For code readability and maintenance, I introduced separator lines between methods, an end-of-file line, and enriched the code with more meaningful comments to clarify the purpose and functionality of each segment. These adjustments not only address the initial feedback but also significantly enhance the overall quality and user-friendliness of the application.


