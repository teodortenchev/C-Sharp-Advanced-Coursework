namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;

    public class PrintCommand : Command
    {
        [Inject]
        private IInventory inventory;

        public PrintCommand(string[] data, IInventory inventory) : base(data)
        {
            this.inventory = inventory;
        }

        public override void Execute()
        {
            string weaponName = Data[0];
            inventory.PrintWeapon("a");
        }
    }
}
