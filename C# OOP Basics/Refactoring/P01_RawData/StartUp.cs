using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class StartUp
    {
        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Car car = CreateCar(parameters);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            PrintResults(command);
            
        }

        private static void PrintResults(string command)
        {
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        public static Car CreateCar(string[] properties)
        {
            string model = properties[0];
            int engineSpeed = int.Parse(properties[1]);
            int enginePower = int.Parse(properties[2]);
            int cargoWeight = int.Parse(properties[3]);
            string cargoType = properties[4];

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire[] tires = new Tire[4];


            int tireNumber = 0;

            for (int i = 0; i < 8; i += 2)
            {
                double tirePressure = double.Parse(properties[5 + i]);
                int tireAge = int.Parse(properties[6 + i]);

                tires[tireNumber] = new Tire(tirePressure, tireAge);
                tireNumber++;
            }
            Car car = new Car(model, engine, cargo, tires);
            return car;
        }
    }
}
