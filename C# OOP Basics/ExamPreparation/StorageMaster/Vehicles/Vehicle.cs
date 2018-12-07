using StorageMaster.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Vehicles
{
    public abstract class Vehicle
    {
        private List<Product> products;

        protected Vehicle(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; private set; }
        public IReadOnlyCollection<Product> Trunk { get => products.AsReadOnly(); }
        public bool IsFull => products.Sum(p => p.Weight) >= Capacity;
        public bool IsEmpty => products.Count == 0;

        public void LoadProduct(Product product)
        {
            if (IsFull == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            products.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty == true)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product product = products[products.Count - 1];
            products.RemoveAt(products.Count - 1);

            return product;
        }
    }
}
