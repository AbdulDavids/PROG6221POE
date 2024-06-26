using System;
using System.Windows;

namespace RecipeManagerApp
{
    public partial class ScaleRecipeDialog : Window
    {
        public double ScalingFactor { get; private set; } = 1.0;

        public ScaleRecipeDialog()
        {
            InitializeComponent();
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ScalingFactorTextBox.Text, out double factor))
            {
                ScalingFactor = factor;
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric scaling factor.");
            }
        }
    }
}
