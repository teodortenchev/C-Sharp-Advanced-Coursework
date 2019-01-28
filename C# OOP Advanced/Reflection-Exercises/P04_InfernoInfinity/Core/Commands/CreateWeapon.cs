namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;
    public class CreateWeapon : Command
    {
        [Inject]
        private IRepository inventory;
        [Inject]
        private IWeaponFactory weaponFactory;
        [Inject]
        private IRarityFactory rarityFactory;


        public CreateWeapon(string[] data, IRepository inventory) : base(data)
        {
            this.inventory = inventory;
        }

        public override void Execute()
        {
            string[] part1 = Data[0].Split();

            string rarity = part1[0];
            string type = part1[1];

            string weaponName = Data[1];


        }
    }
}
