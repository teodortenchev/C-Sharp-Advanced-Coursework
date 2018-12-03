using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;


        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        private double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        private string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" 
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }

        public double Calories
        {
            get { return CalculateCalories(); }
        }

        private double CalculateCalories()
        {
            double modifier = 0d;
            switch (Type.ToLower())
            {
                case "meat":
                    modifier = 1.2d;
                    break;
                case "veggies":
                    modifier = 0.8d;
                    break;
                case "cheese":
                    modifier = 1.1d;
                    break;
                case "sauce":
                    modifier = 0.9d;
                    break;
            }

            return 2 * Weight * modifier;
        }
    }
}
