namespace P04_InfernoInfinity.Models.Weapons
{
    using Contracts;

    public class Knife : Weapon
    {
        private const int MinDMG = 3;
        private const int MaxDMG = 4;
        private const int MaxGems = 2;

        public Knife(IRarity rarity, string name) : base(rarity, name, MaxGems, MinDMG, MaxDMG)
        {
        }

    }
}
