namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;
    public class CreateCommand : Command
    {
        [Inject]
        private IInventory inventory;
        [Inject]
        private IWeaponFactory weaponFactory;
        [Inject]
        private IRarityFactory rarityFactory;


        public CreateCommand(string[] data, IInventory inventory, 
            IWeaponFactory weaponFactory, IRarityFactory rarityFactory) : base(data)
        {
            this.inventory = inventory;
            this.weaponFactory = weaponFactory;
            this.rarityFactory = rarityFactory;
            
        }

        public override void Execute()
        {
            string[] part1 = Data[0].Split();

            string rarityType = part1[0];
            string weaponType = part1[1];

            string weaponName = Data[1];

            IRarity rarity = rarityFactory.CreateRarity(rarityType);
            IWeapon weapon = weaponFactory.CreateWeapon(rarity, weaponName, weaponType);

            inventory.AddWeapon(weapon);


        }
    }
}
