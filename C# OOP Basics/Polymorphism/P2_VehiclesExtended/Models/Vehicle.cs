using System;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }

                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }


        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public virtual void Drive(double distanceKM)
        {
            double fuelNeeded = FuelConsumption * distanceKM;

            if (fuelNeeded > FuelQuantity)
            {
                throw new Exception($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= fuelNeeded;

            Console.WriteLine($"{GetType().Name} travelled {distanceKM} km");
        }

        public virtual void Refuel(double liters)
        {
            if (FuelQuantity + liters > TankCapacity)
            {
                throw new Exception($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters > 0)
            {
                FuelQuantity += liters;
            }
            else
            {
                throw new Exception("Fuel must be a positive number");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
