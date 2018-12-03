using System;
using WildFarm.FoodItems;
using WildFarm.Models;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            WeightGain = 0.30;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
