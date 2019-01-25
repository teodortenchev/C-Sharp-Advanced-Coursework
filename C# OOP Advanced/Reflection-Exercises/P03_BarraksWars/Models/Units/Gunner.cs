namespace P03_BarraksWars.Models.Units
{
    class Gunner : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultDamage = 20;

        public Gunner ()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
