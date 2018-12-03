using System;

namespace WildFarm.Models
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        protected double WeightGain { get; set; }
        public bool LikesFood { get; set; }
        //TODO Don't forget about LIKESFOOD

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = FoodEaten;
            LikesFood = true;
        }

        public abstract void ProduceSound();

        public virtual void Eat(Food food)
        {
            if (!LikesFood)
            {
                throw new Exception($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            Weight += WeightGain * food.Quantity;
            FoodEaten+= food.Quantity;
        }
    }
}
