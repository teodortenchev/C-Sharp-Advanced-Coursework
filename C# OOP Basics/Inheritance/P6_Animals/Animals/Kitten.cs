using System;

namespace P6_Animals.Animals
{
    public class Kitten : Cat
    {
        private const string gender = "Female";

        public Kitten(string name, int age) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
