using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class Ingredient

        //--------------------------------------------------------------------------------

    {
        private string unit;

        // Properties
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }
        public double OriginalQuantity { get; private set; }


        //--------------------------------------------------------------------------------

        // Ingredient constructor

        public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unit;
            Calories = calories;
            FoodGroup = foodGroup;
            OriginalQuantity = quantity;  

        }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            this.unit = unit;
        }


        //--------------------------------------------------------------------------------
        // overrides the ToString method to return a string representation of the ingredient cos I'm lazy haha
        public override string ToString()
        {
            return $"{Quantity} {UnitOfMeasurement} of {Name}, {Calories} cal";
         }
    }

}
