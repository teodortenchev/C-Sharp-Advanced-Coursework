using System;
using WildFarm.Animals;
using WildFarm.Models;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, double weight, string[] args)
        {

            switch (type)
            {
                case "Cat":
                    string livingRegion = args[3];
                    string breed = args[4];
                    return new Cat(name, weight, livingRegion, breed);
                case "Tiger":
                    livingRegion = args[3];
                    breed = args[4];
                    return new Tiger(name, weight, livingRegion, breed);
                case "Dog":
                    livingRegion = args[3];
                    return new Dog(name, weight, livingRegion);

                case "Hen":
                    double wingSize = double.Parse(args[3]);
                    return new Hen(name, weight, wingSize);

                case "Owl":
                    wingSize = double.Parse(args[3]);
                    return new Owl(name, weight, wingSize);

                case "Mouse":
                    livingRegion = args[3];
                    return new Mouse(name, weight, livingRegion);

                default:
                    throw new Exception("Invalid input!");
            }


        }
    }
}
