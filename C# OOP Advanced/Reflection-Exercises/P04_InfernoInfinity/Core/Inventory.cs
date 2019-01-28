namespace P04_InfernoInfinity.Core
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class Inventory : IRepository
    {
        private Dictionary<string, IWeapon> weaponStorage;


        public Inventory()
        {
            weaponStorage = new Dictionary<string, IWeapon>();
        }

        public void AddGemToSocket(string weaponName, int gemSlot, IGem gem)
        {
            IWeapon weapon = weaponStorage[weaponName];
            weapon.AddGem(gemSlot, gem);
        }

        public void CreateWeapon(IWeapon weapon)
        {
            weaponStorage.Add(weapon.Name, weapon);
        }

        public void PrintWeapon(string weaponName)
        {
            IWeapon weapon = weaponStorage[weaponName];

            Console.WriteLine(weapon);
        }

        public void RemoveGemFromSocket(string weaponName, int gemSlot, IGem gem)
        {
            IWeapon weapon = weaponStorage[weaponName];
            weapon.RemoveGem(gemSlot, gem);
        }
    }
}
