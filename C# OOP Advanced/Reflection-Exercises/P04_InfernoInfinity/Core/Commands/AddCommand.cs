namespace P04_InfernoInfinity.Core.Commands
{
    using Contracts;
    using Core.Factories;
    public class AddCommand : Command
    {
        [Inject]
        private IInventory inventory;
        
        private IGemFactory gemFactory;

        public AddCommand(string[] data, IInventory inventory) : base(data)
        {
            this.inventory = inventory;
            gemFactory = new GemFactory();
        }

        public override void Execute()
        {
            string weaponName = Data[1];
            int gemSlot = int.Parse(Data[2]);
            string[] gemInfo = Data[3].Split();
            string gemQuality = gemInfo[0];
            string gemType = gemInfo[1];

            IGem gem = gemFactory.CreateGem(gemType, gemQuality);

            inventory.AddGemToSocket(weaponName, gemSlot, gem);
        }
    }
}
