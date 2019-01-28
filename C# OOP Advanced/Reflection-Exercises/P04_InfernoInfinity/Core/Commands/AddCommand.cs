namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;

    public class AddCommand : Command
    {
        [Inject]
        private IInventory inventory;
        [Inject]
        private IGemFactory gemFactory;

        public AddCommand(string[] data, IInventory inventory) : base(data)
        {
            this.inventory = inventory;
        }

        public override void Execute()
        {
            string weaponName = Data[0];
            int gemSlot = int.Parse(Data[1]);
            string[] gemInfo = Data[2].Split();
            string gemQuality = gemInfo[0];
            string gemType = gemInfo[1];

            IGem gem = gemFactory.CreateGem(gemType, gemQuality);

            inventory.AddGemToSocket(weaponName, gemSlot, gem);
        }
    }
}
