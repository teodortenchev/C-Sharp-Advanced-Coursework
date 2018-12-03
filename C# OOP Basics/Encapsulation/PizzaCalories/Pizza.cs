using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {

        private string name;
        private List<Topping> toppings;
        public Dough Dough { get; set; }


        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            private set { toppings = value; }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }





        public double TotalCalories
        {
            get { return CalculateTotalCalories(); }
        }

        private double CalculateTotalCalories()
        {
            if (Toppings.Count < 1)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            return Dough.Calories + Toppings.Sum(x => x.Calories);
        }

        public void AddTopping(Topping topping)
        {
            if (Toppings.Count < 10)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }


    }
}
