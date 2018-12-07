using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        private Vehicle[] garage;
        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            garage = new Vehicle[GarageSlots];
            products = new List<Product>();
            FillGarage(vehicles);

        }

        private void FillGarage(IEnumerable<Vehicle> vehicles)
        {
            int slot = 0;

            foreach (var vehicle in vehicles)
            {
                garage[slot++] = vehicle;
            }
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int GarageSlots { get; set; }
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(garage);
        public IReadOnlyCollection<Product> Products => products.AsReadOnly();

        /// <summary>
        /// Returns true if the sum of the products’ weights is equal to or larger than the storage capacity.
        /// </summary>
        public bool IsFull => products.Sum(p => p.Weight) >= Capacity;

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            if (garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            bool hasEmptySpace = deliveryLocation.Garage.Any(v => v == null);

            if (hasEmptySpace == false)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            int targetSlot = Array.FindIndex(deliveryLocation.garage, v => v == null);

            garage[garageSlot] = null;

            deliveryLocation.garage[targetSlot] = vehicle;

            return targetSlot;
        }


        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull == true)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = GetVehicle(garageSlot);

            int productsAdded = 0;

            while (this.IsFull == false || vehicle.IsEmpty == false)
            {
                Product product = vehicle.Unload();
                products.Add(product);
                productsAdded++;
            }

            return productsAdded;
        }
    }
}
