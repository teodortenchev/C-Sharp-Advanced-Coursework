namespace P03_BarraksWars.Core.Actions
{
    using P03_BarraksWars.Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            Repository = repository;
        }

        public IRepository Repository
        {
            get
            {
                return repository;
            }
            set
            {
                repository = value;
            }
        }

        public override string Execute()
        {
            string unitType = Data[1];
            Repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }


    }
}
