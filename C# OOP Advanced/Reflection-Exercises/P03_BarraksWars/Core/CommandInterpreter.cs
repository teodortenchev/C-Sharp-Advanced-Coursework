namespace P03_BarraksWars.Core
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public IRepository Repository { get; private set; }
        public IUnitFactory UnitFactory { get; private set; }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Type commandType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name.StartsWith(commandName, StringComparison.CurrentCultureIgnoreCase));

            var instance = Activator.CreateInstance(commandType, new object[] { data, Repository, UnitFactory });

            var result = ((IExecutable)instance);

            return result;
        }
    }
}
