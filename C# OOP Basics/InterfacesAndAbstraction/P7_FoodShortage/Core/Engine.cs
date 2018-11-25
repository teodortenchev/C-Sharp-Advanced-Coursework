using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Contracts;
using FoodShortage.Models;

namespace FoodShortage.Core
{
    public class Engine
    {

        private static Dictionary<string, IBuyer> foodBuyers;

        public Engine()
        {
            foodBuyers = new Dictionary<string, IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();

                if(args.Length == 4)
                {
                    string name = args[0];
                    int age = int.Parse(args[1]);
                    string id = args[2];
                    string birthDate = args[3];

                    IBuyer citizen = new Citizen(name, age, id, birthDate);
                    
                    if(!foodBuyers.ContainsKey(name))
                    {
                        foodBuyers.Add(name, citizen);
                    }
                }

                if(args.Length == 3)
                {
                    string name = args[0];
                    int age = int.Parse(args[1]);
                    string group = args[2];

                    IBuyer rebel = new Rebel(name, age, group);

                    if (!foodBuyers.ContainsKey(name))
                    {
                        foodBuyers.Add(name, rebel);
                    }
                }

            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string name = input;

                AddFood(name);

                input = Console.ReadLine();
            }

           int totalFoodPurchased = CalculateTotalFood();

            Console.WriteLine(totalFoodPurchased);
        }

        private int CalculateTotalFood()
        {
            int totalFood = 0;

            foreach (var person in foodBuyers)
            {
                totalFood += person.Value.Food;
            }

            return totalFood;
        }

        private void AddFood(string name)
        {
            if(foodBuyers.ContainsKey(name))
            {
                foodBuyers[name].BuyFood();
            }
        }
    }
}
