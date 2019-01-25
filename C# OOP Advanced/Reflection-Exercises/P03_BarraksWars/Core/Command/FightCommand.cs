namespace P03_BarraksWars.Core.Commmand
{
    using P03_BarraksWars.Contracts;
    using System;

    public class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);

            return null;
        }
    }
}
