namespace P03_BarraksWars.Core
{
    using Contracts;
    using System;

    class Engine : IRunnable
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    IExecutable command = commandInterpreter.InterpretCommand(data, commandName);
                    string result = command.Execute();

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        //private string InterpredCommand(string[] data, string commandName)
        //{
        //    Type commandType = Assembly.GetExecutingAssembly().GetTypes()
        //        .FirstOrDefault(x => x.Name.StartsWith(commandName, StringComparison.CurrentCultureIgnoreCase));

        //    var instance = Activator.CreateInstance(commandType, new object[] { data, repository, unitFactory });

        //    var result = ((IExecutable)instance).Execute();

        //    return result;
        //}




    }
}
