namespace P03_BarraksWars.Core.Actions
{
    using P03_BarraksWars.Contracts;

    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data)
        {
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public IRepository Repository
        {
            get
            { return repository; }
            private set { repository = value; }
        }
        public IUnitFactory UnitFactory
        {
            get
            { return unitFactory; }
            private set { unitFactory = value; }
        }


        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = UnitFactory.CreateUnit(unitType);
            Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
