using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private ProductFactory productFactory;
        private StorageFactory storageFactory;
        private Dictionary<string, int> productPool;
        private Vehicle currentVehicle;
        private List<Storage> storageRegistry;

        public StorageMaster()
        {
            productFactory = new ProductFactory();
            storageFactory = new StorageFactory();
            productPool = new Dictionary<string, int>();
            storageRegistry = new List<Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);


            if (!productPool.ContainsKey(type))
            {
                productPool.Add(type, 1);
            }

            productPool[type]++;

            string output = $"Added {type} to pool";

            return output;

        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = storageFactory.CreateStorage(type, name);
            storageRegistry.Add(storage);

            string output = $"Registered {type}";

            return output;
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);

            currentVehicle = storage.GetVehicle(garageSlot);

            string result = $"Selected {currentVehicle.GetType().Name}";

            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            throw new NotImplementedException();
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            throw new NotImplementedException();
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }

        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
