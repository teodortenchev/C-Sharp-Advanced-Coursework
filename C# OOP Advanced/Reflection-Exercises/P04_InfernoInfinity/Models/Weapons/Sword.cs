namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;

    public class Sword : Weapon
    {
        private const int MinDMG = 4;
        private const int MaxDMG = 6;
        private const int MaxGems = 3;

        public Sword(IRarity rarity, string name) : base(rarity, name, MaxGems, MinDMG, MaxDMG)
        {
        }
    }
}
