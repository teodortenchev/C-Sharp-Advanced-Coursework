using System;

namespace Vehicles.Models
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (FuelQuantity + liters > TankCapacity)
            {
                throw new Exception($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters > 0)
            {
                FuelQuantity += liters * 0.95;
            }
            else
            {
                throw new Exception("Fuel must be a positive number");
            }
            
        }
    }
}
