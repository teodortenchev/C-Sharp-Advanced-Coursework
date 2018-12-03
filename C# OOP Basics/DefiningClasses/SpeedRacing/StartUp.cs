using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                //“<Model> <FuelAmount> <FuelConsumptionFor1km>"
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1km = double.Parse(tokens[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);

                if (!cars.Contains(car))
                {
                    cars.Add(car);
                }
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0].ToLower() == "end")
                {
                    break;
                }
                //“Drive <CarModel>  <amountOfKm>”
                string model = tokens[1];
                int distanceInKm = int.Parse(tokens[2]);

                Car targetCar = cars.Where(x => x.Model == model).FirstOrDefault();
                targetCar.Drive(distanceInKm);
                
            }

            foreach (Car vehicle in cars)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
