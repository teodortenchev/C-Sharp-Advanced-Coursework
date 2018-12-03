namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + 1.4, tankCapacity)
        {
        }

        public void DriveEmpty(double distance)
        {
            FuelConsumption -= 1.4;
            base.Drive(distance);
            FuelConsumption += 1.4;
        }
    }
}
