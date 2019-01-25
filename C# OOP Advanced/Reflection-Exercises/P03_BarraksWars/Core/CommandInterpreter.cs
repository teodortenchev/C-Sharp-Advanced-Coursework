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
                .FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            if (commandType == null)
            {
                throw new Exception("Invalid command!");
            }

            var instance = Activator.CreateInstance(commandType, new object[] { data, Repository, UnitFactory });

            IExecutable result = (IExecutable)instance;

            return result;
        }
    }
}
