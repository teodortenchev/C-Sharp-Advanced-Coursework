using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class Warehouse : Storage
    {
        private static readonly Vehicle[] DefaultVehicles =
        {
            new Semi(),
            new Semi(),
            new Semi(),
        };

        public Warehouse(string name) 
            : base(name, capacity: 10, garageSlots: 10, vehicles: DefaultVehicles)
        {
        }
    }
}
