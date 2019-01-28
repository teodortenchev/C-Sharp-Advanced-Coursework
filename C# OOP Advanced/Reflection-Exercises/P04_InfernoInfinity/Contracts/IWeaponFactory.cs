namespace P04_InfernoInfinity.Contracts
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(IRarity rarity, string name, string type);
    }
}
