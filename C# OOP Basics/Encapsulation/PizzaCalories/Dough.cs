using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;


        public Dough(string flourType, string technique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = technique;
            Weight = weight;
        }


        private double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                value = value.ToLower();

                if (value != "homemade" && value != "chewy" && value != "crispy")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        private string FlourType
        {
            get { return flourType; }
            set
            {
                value = value.ToLower();
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public double Calories
        {
            get { return CalculateCalories(); }
        }

        private double CalculateCalories()
        {
            double modifierOne = -1d;
            double modifierTwo = -1d;

            switch (FlourType)
            {
                case "white":
                    modifierOne = 1.5d;
                    break;
                case "wholegrain":
                    modifierOne = 1.0d;
                    break;
            }
            switch (BakingTechnique)
            {
                case "crispy":
                    modifierTwo = 0.9d;
                    break;
                case "chewy":
                    modifierTwo = 1.1d;
                    break;
                case "homemade":
                    modifierTwo = 1.0d;
                    break;
            }
            return (2 * Weight) * modifierOne * modifierTwo;
        }
    }
}
