using System;

namespace P7CustomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var commandInterpreter = new CommandInterpreter<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                switch (command)
                {
                    case "Add":
                        commandInterpreter.Add(inputArgs[1]);
                        break;
                    case "Remove":
                        commandInterpreter.Remove(int.Parse(inputArgs[1]));
                        break;
                    case "Contains":
                        commandInterpreter.Contains(inputArgs[1]);
                        break;
                    case "Swap":
                        commandInterpreter.Swap(int.Parse(inputArgs[1]), int.Parse(inputArgs[2]));
                        break;
                    case "Greater":
                        commandInterpreter.Greater(inputArgs[1]);
                        break;
                    case "Max":
                        commandInterpreter.Max();
                        break;
                    case "Min":
                        commandInterpreter.Min();
                        break;
                    case "Print":
                        commandInterpreter.Print();
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }

                input = Console.ReadLine();
            }


        }
    }
}
