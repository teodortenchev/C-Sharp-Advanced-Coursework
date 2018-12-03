using System;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; private set; }

        public Vehicle (double fuelQuantity, double fuelConsumption)
        {
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
            if (liters > 0)
            {
                FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
