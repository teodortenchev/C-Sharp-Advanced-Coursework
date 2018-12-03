using System;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class ApplicationEngine
    {
        private IVehicle car;
        private IVehicle truck;

        public ApplicationEngine()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
        }

        public void Run()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                ExecuteCommand(commandArgs);
            }

            PrintResults();


        }

        private void ExecuteCommand(string[] commandArgs)
        {
            if (commandArgs[0] == "Drive")
            {
                double distance = double.Parse(commandArgs[2]);
                if (commandArgs[1] == "Car")
                {
                    try
                    {
                        car.Drive(distance);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (commandArgs[1] == "Truck")
                {
                    try
                    {
                        truck.Drive(distance);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (commandArgs[0] == "Refuel")
            {
                double fuelAmount = double.Parse(commandArgs[2]);

                if (commandArgs[1] == "Car")
                {
                    car.Refuel(fuelAmount);
                }
                else if (commandArgs[1] == "Truck")
                {
                    truck.Refuel(fuelAmount);
                }
            }
        }

        private void PrintResults()
        {
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

    }
}
