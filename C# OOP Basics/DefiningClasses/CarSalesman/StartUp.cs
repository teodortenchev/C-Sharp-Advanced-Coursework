using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSalesman
{
    public class StartUp
    {
        static List<Engine> engines;
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //< Model > < Power > < Displacement > < Efficiency >
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine(model, power);

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int displacement))
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = input[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(engine);

            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = GetEngine(input[1]);
                Car car = new Car(model, engine);
                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int weight))
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = input[2];
                        car = new Car(model, engine, color);
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car = new Car(model, engine, weight, color);
                }
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model + ":");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.Write($"    Displacement: ");
                Console.WriteLine(car.Engine.Displacement == 0 ? "n/a" : car.Engine.Displacement.ToString());
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.Write($"  Weight: ");
                Console.WriteLine(car.Weight == 0 ? "n/a" : car.Weight.ToString());
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
//<CarModel>:
//  <EngineModel>:
//    Power: <EnginePower>
//    Displacement: <EngineDisplacement>
//    Efficiency: <EngineEfficiency>
//  Weight: <CarWeight>
//  Color: <CarColor>

        private static Engine GetEngine(string engineType)
        {
            return engines.Where(x => x.Model == engineType).FirstOrDefault();
        }
    }
}

