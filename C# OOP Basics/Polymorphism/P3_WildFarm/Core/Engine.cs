using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        private AnimalFactory animalFacory;
        private FoodFactory foodFactory;
        private List<Animal> animals;

        public Engine()
        {
            animalFacory = new AnimalFactory();
            foodFactory = new FoodFactory();
            animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();

                string animalType = args[0];
                string animalName = args[1];
                double animalWeight = double.Parse(args[2]);

                string[] foodArgs = Console.ReadLine().Split();

                string foodType = foodArgs[0];
                int quantity = int.Parse(foodArgs[1]);

                Animal animal = animalFacory.CreateAnimal(animalType, animalName, animalWeight, args);

                animals.Add(animal);

                Food food = foodFactory.CreateFood(foodType, quantity);

                animal.ProduceSound();

                try
                {
                    GiveFood(food, animalName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }

            PrintAnimalsInfo();
        }

        //Let's assume animal name is the unique identifier, altough ideally this should not be the case.
        private void GiveFood(Food food, string animalName)
        {
            Animal animal = animals.FirstOrDefault(a => a.Name == animalName);

            string animalType = animal.GetType().Name;
            string foodType = food.GetType().Name;

            switch (animalType)
            {
                case "Hen":
                    break;

                case "Mouse":

                    if (foodType != "Vegetable" && foodType != "Fruit")
                    {
                        animal.LikesFood = false;
                    }
                    break;


                case "Cat":
                    if (foodType != "Vegetable" && foodType != "Meat")
                    {
                        animal.LikesFood = false;
                    }
                    break;
                case "Tiger":
                case "Dog":
                case "Owl":
                    if (foodType != "Meat")
                    {
                        animal.LikesFood = false;
                    }
                    break;

            }

            animal.Eat(food);
            animal.LikesFood = true;


        }
        private void PrintAnimalsInfo()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
