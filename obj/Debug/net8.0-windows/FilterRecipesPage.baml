   M S B A M L   `   `   `  ����  PROG6221ConsoleAppWPF(    "RecipeManagerApp.FilterRecipesPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Filter Recipes��5      .��5      �� $��10q�6   .+�5   
   �� $��Filter Recipes��6   $��22(�6*   $
��Bold"�68   $��0,0,0,10q�6J   �� 5   
   $��Ingredient Name:��6   $
��Bold"�6,   �� 5	   
   -   5         ��Name$ IngredientNameTextBox��5	      $��0,5,0,10q�61   �� 5   
   $��Food Group:��6   $
��Bold"�6'   �� 5   
   -   5         ��Name$ FoodGroupComboBox��5      $��0,5,0,10q�6.   .@�5      �� $��Protein��6   �� 5      $��Carbohydrates��6   �� 5      $
��Fats��6   �� 5      $��Vitamins��6   �� 5      $��Minerals��6   5      �� 5   
   $��Maximum Calories:��6   $
��Bold"�6-   �� 5   
   -   5        $ MaxCaloriesTextBox��5      $��0,5,0,10q�6.   �� 5   
   -   5        $��Apply Filters��5      $
��0,10q�6D   �� 5   
   -   5         ��Name$ FilteredRecipesListView��5      $��10q�64    �� View 5      �� 5      .P�5      �� $��Recipe Name��6%    �� DisplayMemberBinding 6:   �� *Name+�� 5      $��Ingredients��6%    6:   �� *IngredientsDisplay+�� 5      $��Steps��6%    64   �� *StepsDisplay+5       5"      5#      5$      