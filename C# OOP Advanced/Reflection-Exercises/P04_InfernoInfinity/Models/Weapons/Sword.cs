namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;

    public class Sword : Weapon
    {
        private const int MaxGems = 3;

        public Sword(IRarity rarity, string name) : base(rarity, name, socketsCount: MaxGems)
        {
        }
    }
}
