namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        void Drive(double distanceKM);
        void Refuel(double liters);
    }
}
