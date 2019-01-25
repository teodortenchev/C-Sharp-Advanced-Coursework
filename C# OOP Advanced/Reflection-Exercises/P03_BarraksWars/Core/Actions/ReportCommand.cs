namespace P03_BarraksWars.Core.Actions
{
    using P03_BarraksWars.Contracts;

    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }
    }
}
