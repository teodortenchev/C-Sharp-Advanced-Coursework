namespace P04_InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        private const int strength = 2;
        private const int agility = 8;
        private const int vitality = 4;

        public Amethyst(string quality)
            : base(quality, strength, agility, vitality)
        {
        }
    }
}
