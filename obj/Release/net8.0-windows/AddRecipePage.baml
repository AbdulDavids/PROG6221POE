   M S B A M L   `   `   `  ����   PROG6221ConsoleAppWPF$    RecipeManagerApp.AddRecipePage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  
Add Recipe��.���� $��10q�.+��� $��Recipe Name:��$
��Bold"��� -    ��Name$ RecipeNameTextBox��$��0,5,0,10q��� $��Ingredients:��$
��Bold"�� $��0,5,0,10q� � RowDefinitions �� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $��* ��� $��50 ��� $	��100 ��� $��50 ��� $	��100 ��� $
��Auto �.+��� $
��Name��$
��Bold"�$��0��$��0��$��0,0,10,0q��� $��Quantity��$
��Bold"�$��0��$��1��$��0,0,10,0q��� $
��Unit��$
��Bold"�$��0��$��2��$��0,0,10,0q��� $��Calories��$
��Bold"�$��0��$��3��$��0,0,10,0q��� $��
Food Group��$
��Bold"�$��0��$��4��$��0,0,10,0q��� -   $ IngredientNameTextBox��$��1��$��0��$��0,0,10,0q��� -   $ QuantityTextBox��$��1��$��1��$��0,0,10,0q��� -    ��Name$ UnitComboBox��$��1��$��2��$��0,0,10,0q�.@��� $��grams���� $��ml���� $
��cups���� $��pieces���� -   $ CaloriesTextBox��$��1��$��3��$��0,0,10,0q��� -   $ FoodGroupComboBox��$��1��$��4��$��0,0,10,0q�.@��� $��Protein���� $��Carbohydrates���� $
��Fats���� $��Vitamins���� $��Minerals���� -   $	��Add��$��1��$��5���� $��0,5,0,10q����� *Ingredients+ �� View �� .P��� $
��Name�� �� DisplayMemberBinding �� *Name+�� $��Quantity�� �� *
Quantity+�� $
��Unit�� �� *Unit+�� $��Calories�� �� *
Calories+�� $��
Food Group�� �� *	FoodGroup+�� $��Preparation Steps:��$
��Bold"�$��0,10,0,0q�� $��0,5,0,10q� �� $��* ��� $
��Auto �.+��� -   $ StepTextBox��$��0��$��0,0,10,0q��� -	   $��Add Step��$��1���� $��0,5,0,10q����� *Steps+ �� .P��� $
��Step�� �� �� -
   $��Save Recipe��$��10q�