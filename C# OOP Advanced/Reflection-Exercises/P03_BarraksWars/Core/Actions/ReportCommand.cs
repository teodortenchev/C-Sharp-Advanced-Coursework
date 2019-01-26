namespace P03_BarraksWars.Core.Actions
{
    using P03_BarraksWars.Contracts;

    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository)
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
            private set
            {
                repository = value;
            }
        }

        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }
    }
}
