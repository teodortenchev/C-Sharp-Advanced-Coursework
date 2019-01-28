namespace P04_InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        private const int strength = 1;
        private const int agility = 4;
        private const int vitality = 9;

        public Emerald(string quality)
            : base(quality, strength, agility, vitality)
        {
        }
    }
}
