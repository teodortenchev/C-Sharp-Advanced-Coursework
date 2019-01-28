namespace P04_InfernoInfinity.Contracts
{
    public interface IRepository
    {
        void CreateWeapon(IWeapon weapon);
        void AddGemToSocket(string weaponName, int gemSlot, IGem gem);
        void RemoveGemFromSocket(string weaponName, int gemSlot, IGem gem);
        void PrintWeapon(string weaponName);
    }
}
