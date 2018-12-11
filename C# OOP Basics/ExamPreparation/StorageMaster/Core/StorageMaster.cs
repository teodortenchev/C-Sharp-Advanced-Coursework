using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private ProductFactory productFactory;
        private StorageFactory storageFactory;
        private Dictionary<string, Stack<Product>> productPool;
        private Vehicle currentVehicle;
        private List<Storage> storageRegistry;

        public StorageMaster()
        {
            productFactory = new ProductFactory();
            storageFactory = new StorageFactory();
            productPool = new Dictionary<string, Stack<Product>>();
            storageRegistry = new List<Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);


            if (!productPool.ContainsKey(type))
            {
                productPool.Add(type, new Stack<Product>());
            }

            productPool[type].Push(product);

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
            int loadedProductsCount = 0;
            int totalProducts = productNames.Count();

            foreach (var name in productNames)
            {
                if (currentVehicle.IsFull)
                {
                    break;
                }

                //TODO: Think about the case in which the key does not exist, check the count separately below to avoid problems.
                if (!productPool.ContainsKey(name) || productPool[name].Count == 0)
                {
                    throw new InvalidOperationException($"{name} is out of stock!");
                }

                Product product = productPool[name].Pop();

                currentVehicle.LoadProduct(product);
                loadedProductsCount++;
            }

            string output = $"Loaded {loadedProductsCount}/{totalProducts} products into {currentVehicle.GetType().Name}";

            return output;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (storageRegistry.FirstOrDefault(s => s.Name == sourceName) == null)
            {
                throw new InvalidOperationException("Invalid source storage");
            }
            if (storageRegistry.FirstOrDefault(s => s.Name == destinationName) == null)
            {
                throw new InvalidOperationException("Invalid destinations storage");
            }

            Storage sourceStorage = storageRegistry.First(s => s.Name == sourceName);
            Storage destinationStorage = storageRegistry.First(s => s.Name == destinationName);

            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            int destinationSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            string output = $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationSlot})";

            return output;

        }

        /// <summary>
        /// Gets the vehicle in the storage’s garage slot. Then, the vehicle is unloaded at the storage.
        /// </summary>
        /// <param name="storageName"></param>
        /// <param name="garageSlot"></param>
        /// <returns></returns>
        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);

            Vehicle vehicle = storage.GetVehicle(garageSlot);

            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            int productsInVehicle = vehicle.Trunk.Count();

            string output = $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";

            return output;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = storageRegistry.FirstOrDefault(s => s.Name == storageName);

            Dictionary<string, int> productsAndCounts = new Dictionary<string, int>();

            foreach (var product in storage.Products)
            {
                string productName = product.GetType().Name;

                if (!productsAndCounts.ContainsKey(productName))
                {
                    productsAndCounts.Add(productName, 1);
                }

                productsAndCounts[productName]++;
            }

            string[] productsAndCountString = productsAndCounts.OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key).Select(kvp => $"{kvp.Key} ({kvp.Value})").ToArray();

            double weight = storage.Products.Sum(p => p.Weight);

            string stockLine = $"({weight} / {storage.Capacity}): [{String.Join(',', productsAndCountString)}]";

            string[] garageRepresentation = new string[storage.GarageSlots];

            int index = 0;

            foreach (var slot in storage.Garage)
            {
                if(slot == null)
                {
                    garageRepresentation[index] = "empty";
                }
                else
                {
                    garageRepresentation[index] = slot.GetType().Name;
                }

                index++;
            }

            string garageLine = $"Garage: [{String.Join('|', garageRepresentation)}]";


            //Shorter way to do above:
            //string[] garageArrayRepresentation = new string[storage.GarageSlots];
            //garageArrayRepresentation = storage.Garage.Select(g => g == null ? "empty" : g.GetType().Name).ToArray();

            string result = stockLine + Environment.NewLine + garageLine;
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
