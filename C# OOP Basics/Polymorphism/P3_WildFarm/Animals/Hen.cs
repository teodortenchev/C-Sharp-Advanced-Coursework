using System;
using WildFarm.Models;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            WeightGain = 0.35;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
