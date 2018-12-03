namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        void Drive(double distanceKM);
        void Refuel(double liters);
    }
}
