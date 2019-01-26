namespace P03_BarraksWars.Core
{
    using Contracts;
    using P03_BarraksWars.Core.Actions;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }



        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Type commandType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            if (commandType == null)
            {
                throw new Exception("Invalid command!");
            }

            //Gets the fields which have custom attribute of Inject
            FieldInfo[] fieldsToInject = commandType
                  .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                  .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute))).ToArray();

            //Gets the fields types to inject from the service Provider.
            object[] injectArgs = fieldsToInject.Select(f => this.serviceProvider.GetService(f.FieldType)).ToArray();

            //arguments to satisfy all the constructors in all commands. (must find a better way)
            object[] constrArgs = new object[] { data }.Concat(injectArgs).ToArray();

            IExecutable instance = (IExecutable)Activator.CreateInstance(commandType, constrArgs);

            return instance;
        }
    }
}
