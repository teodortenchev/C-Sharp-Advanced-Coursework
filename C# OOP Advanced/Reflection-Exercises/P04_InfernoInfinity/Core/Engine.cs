namespace P04_InfernoInfinity.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                commandInterpreter.Interpret(data);

                input = Console.ReadLine();
            }
        }
    }
}
