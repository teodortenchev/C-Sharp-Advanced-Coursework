namespace P04_InfernoInfinity.Contracts
{
    using System.Collections.Generic;

    public interface IInventory
    {
        void AddWeapon(IWeapon weapon);
        void AddGemToSocket(string weaponName, int gemSlot, IGem gem);
        void RemoveGemFromSocket(string weaponName, int gemSlot, IGem gem);
        void PrintWeapon(string weaponName);

        IReadOnlyDictionary<string, IWeapon> Weapons { get; }
    }
}
