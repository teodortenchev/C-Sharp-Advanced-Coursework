namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;

    public class Axe : Weapon
    {
        private const int MinDMG = 5;
        private const int MaxDMG = 10;
        private const int MaxGems = 4;

        public Axe(IRarity rarity, string name) : base(rarity, name, MaxGems, MinDMG, MaxDMG)
        {
        }
    }
}
