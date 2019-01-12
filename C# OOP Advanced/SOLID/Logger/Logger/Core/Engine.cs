namespace Logger.Core
{
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpeter)
        {
            this.commandInterpreter = commandInterpeter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] inputArgs = input.Split('|');
                this.commandInterpreter.AddMessage(inputArgs);


                input = Console.ReadLine();
            }

            commandInterpreter.PrintAppenders();
        }
    }
}
