using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class Ingredient
    {
        // Properties
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }

        // Ingredient constructor
        public Ingredient(string name, double quantity, string unitOfMeasurement)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
        }

        // overrides the ToString method to return a string representation of the ingredient cos I'm lazy haha
        public override string ToString()
        {
            return $"{Quantity} {UnitOfMeasurement} of {Name}";
        }
    }

}
