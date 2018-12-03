﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{
    class StartUp
    {
        static List<Engine> engines;
        static List<Car> cars;

        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());

            AddEngines(engineCount);

            int carsCount = int.Parse(Console.ReadLine());
            AddCars(carsCount);

            PrintCars();

            
        }

        private static void PrintCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void AddCars(int carsCount)
        {
            cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                string engineModel = parameters[1];
                Engine engine = engines.FirstOrDefault(x => x.model == engineModel);

                int weight = -1;

                if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
                {
                    cars.Add(new Car(model, engine, weight));
                }
                else if (parameters.Length == 3)
                {
                    string color = parameters[2];
                    cars.Add(new Car(model, engine, color));
                }
                else if (parameters.Length == 4)
                {
                    string color = parameters[3];
                    cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }
        }

        private static void AddEngines(int engineCount)
        {
            engines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int power = int.Parse(parameters[1]);

                int displacement = -1;

                if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (parameters.Length == 3)
                {
                    string efficiency = parameters[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
                else if (parameters.Length == 4)
                {
                    string efficiency = parameters[3];
                    engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }
        }

    }

}
