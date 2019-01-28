namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;
    public class RemoveCommand : Command
    {
        [Inject]
        private IInventory inventory;

        public RemoveCommand(string[] data, IInventory inventory) : base(data)
        {
            this.inventory = inventory;
        }

        public override void Execute()
        {
            string weaponName = Data[0];
            int gemSlot = int.Parse(Data[1]);
            IWeapon weapon = inventory.Weapons[weaponName];
            IGem gem = weapon.Sockets[gemSlot];

            if (gem != null)
            {
                weapon.RemoveGem(gemSlot, gem);
            }
        }
    }
}
