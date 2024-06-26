using System;
using System.Globalization;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace RecipeManagerApp
{
    public class IngredientConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var ingredients = value as ObservableCollection<Ingredient>;
            return string.Join(", ", ingredients.Select(i => $"{i.Name} ({i.Quantity} {i.Unit})"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StepsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var steps = value as ObservableCollection<string>;
            return string.Join(", ", steps);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
