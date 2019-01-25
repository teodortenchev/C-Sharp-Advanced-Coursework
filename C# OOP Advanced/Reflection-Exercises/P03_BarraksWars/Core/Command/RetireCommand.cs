namespace P03_BarraksWars.Core.Commmand
{
    using P03_BarraksWars.Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            Repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }


    }
}
