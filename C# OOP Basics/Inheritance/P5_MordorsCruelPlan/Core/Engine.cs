using P5_MordorsCruelPlan.Factories;
using P5_MordorsCruelPlan.Foods;
using P5_MordorsCruelPlan.Moods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P5_MordorsCruelPlan.Core
{
    public class Engine
    {
        private List<Food> foods;
        private MoodFactory moodFactory;
        private FoodFactory foodFactory;

        public Engine()
        {
            foods = new List<Food>();
            moodFactory = new MoodFactory();
            foodFactory = new FoodFactory();
        }

        public void Run()
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];

                Food food = foodFactory.CreateFood(type);
                foods.Add(food);
            }

            int totalHappiness = CalculateHappiness();
            Mood mood = moodFactory.DetermineMood(totalHappiness);

            Console.WriteLine(totalHappiness);
            Console.WriteLine(mood.Name);
        }

        private int CalculateHappiness()
        {
            return foods.Sum(x => x.Happiness);
        }

     
    }
}
