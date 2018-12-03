using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] pizzaInput = Console.ReadLine().Split(' ');
            

            try
            {
                Pizza pizza = new Pizza(pizzaInput[1]);
                string[] tokens = Console.ReadLine().Split(' ');
                Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                pizza.Dough = dough;

                string input;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] inputArgs = input.Split(' ');
                    Topping topping = new Topping(inputArgs[1], double.Parse(inputArgs[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            

            
        }
    }
}
