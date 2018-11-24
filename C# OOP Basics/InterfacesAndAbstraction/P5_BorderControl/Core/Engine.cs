using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private static List<IIdentifiable> detainees;
        private List<IIdentifiable> passedInspection;

        public Engine()
        {
            detainees = new List<IIdentifiable>();
            passedInspection = new List<IIdentifiable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();

                if (args.Length < 3)
                {
                    string robotModel = args[0];
                    string robotId = args[1];

                    IIdentifiable robot = new Robot(robotModel, robotId);

                    detainees.Add(robot);
                }
                else if (args.Length == 3)
                {
                    string name = args[0];
                    int age = int.Parse(args[1]);
                    string id = args[2];

                    IIdentifiable citizen = new Citizen(name, age, id);

                    detainees.Add(citizen);
                }

                input = Console.ReadLine();
            }

            string fakeIdEndingIn = Console.ReadLine();

            CheckId(fakeIdEndingIn);
            PrintDetainees();
        }

        private void CheckId(string fakeIdNumber)
        {
            passedInspection = detainees.Where(x => !x.Id.EndsWith(fakeIdNumber)).ToList();
            detainees = detainees.Where(x => x.Id.EndsWith(fakeIdNumber)).ToList();
        }
        private void PrintDetainees()
        {
            foreach (var detained in detainees)
            {
                Console.WriteLine(detained.Id);
            }
        }
    }
}
