namespace P04_InfernoInfinity.Core
{
    using Contracts;
    using Core.Commands;
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

        public void Interpret(string[] data)
        {
            string commandName = data[0];

            Type commandType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name.StartsWith(data[0]));

            if (commandType == null)
            {
                throw new Exception($"Invalid command! {commandName} might not be implemented.");
            }

            FieldInfo[] fieldsToInject = commandType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute))).ToArray();

            object[] injectArgs = fieldsToInject.Select(f => serviceProvider.GetService(f.FieldType)).ToArray();

            object[] commandArgs = new object[] { data }.Concat(injectArgs).ToArray();

            IExecutable commandInstance = (IExecutable)Activator.CreateInstance(commandType, commandArgs);

            commandInstance.Execute();
        }
    }
}
