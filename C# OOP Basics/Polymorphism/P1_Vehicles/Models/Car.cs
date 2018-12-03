namespace Vehicles.Models
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 0.9)
        {
        }
        
    }
}
