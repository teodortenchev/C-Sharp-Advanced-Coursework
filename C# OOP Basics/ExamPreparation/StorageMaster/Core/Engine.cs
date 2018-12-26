using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster storageMaster;

        public Engine()
        {
            storageMaster = new StorageMaster();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string[] parameters = commandArgs.Skip(1).ToArray();

                string output = "";
                try
                {
                    output = ParseCommand(command, parameters);
                    Console.WriteLine(output);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(storageMaster.GetSummary());
        }

        private string ParseCommand(string command, string[] parameters)
        {
            string result = "";

            switch (command)
            {
                case "AddProduct":
                    string type = parameters[0];
                    double price = double.Parse(parameters[1]);

                    result = storageMaster.AddProduct(type, price);
                    break;

                case "RegisterStorage":
                    type = parameters[0];
                    string name = parameters[1];

                    result = storageMaster.RegisterStorage(type, name);
                    break;

                case "SelectVehicle":
                    string storageName = parameters[0];
                    int garageSlot = int.Parse(parameters[1]);

                    result = storageMaster.SelectVehicle(storageName, garageSlot);
                    break;

                case "LoadVehicle":

                    List<string> productsLoad = new List<string>();

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        productsLoad.Add(parameters[i]);
                    }

                    result = storageMaster.LoadVehicle(productsLoad);

                    break;

                case "SendVehicleTo":
                    string sourceName = parameters[0];
                    int sourceGarageSlot = int.Parse(parameters[1]);
                    string destinationName = parameters[2];

                    result = storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                    break;

                case "UnloadVehicle":
                    storageName = parameters[0];
                    garageSlot = int.Parse(parameters[1]);

                    result = storageMaster.UnloadVehicle(storageName, garageSlot);
                    break;

                case "GetStorageStatus":
                    storageName = parameters[0];

                    result = storageMaster.GetStorageStatus(storageName);
                    break;

                default:
                    throw new InvalidOperationException("Unrecognized command " + command);

            }

            return result;
        }
    }
}
