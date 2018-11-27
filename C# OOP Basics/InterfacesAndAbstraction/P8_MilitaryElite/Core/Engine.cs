using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private List<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            soldiers = new List<ISoldier>();
            soldier = null;

        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();
                string type = args[0];
                int id = int.Parse(args[1]);
                string firstName = args[2];
                string lastName = args[3];


                if (type == "Private")
                {
                    decimal salary = decimal.Parse(args[4]);
                    soldier = new Private(firstName, lastName, id, salary);
                }
                else if (type == "LieutenantGeneral")
                {
                    soldier = GeneratePrivate(id, firstName, lastName, args);
                }
                else if (type == "Engineer")
                {
                    soldier = GenerateEngineer(id, firstName, lastName, args);
                }
                else if(type == "Commando")
                {
                    soldier = GenerateCommando(id, firstName, lastName, args);
                }
                else if(type == "Spy")
                {
                    int codeNumber = int.Parse(args[4]);
                    soldier = GenerateSpy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    soldiers.Add(soldier);
                }

                input = Console.ReadLine();
            }

            ListSoldiers();

        }

        private void ListSoldiers()
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private ISoldier GenerateSpy(int id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(firstName, lastName, id, codeNumber);

            return spy;
        }

        private ISoldier GenerateCommando(int id, string firstName, string lastName, string[] args)
        {
            string corpsAsString = args[5];

            if(!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            ICommando commando = new Commando(firstName, lastName, id, decimal.Parse(args[4]), corps);

            for (int i = 6; i < args.Length; i+= 2)
            {
                string missionName = args[i];
                string missionStateAsString = args[i + 1];

                if (!Enum.TryParse(missionStateAsString, out State state))
                {
                    continue;
                }

                IMission mission = new Mission(missionName, state);

                commando.Missions.Add(mission);
            
            }

            return commando;
        }

        private ISoldier GenerateEngineer(int id, string firstName, string lastName, string[] args)
        {
            string corpsAsString = args[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }
            IEngineer engineer = new Engineer(firstName, lastName, id, decimal.Parse(args[4]), corps);

            for (int i = 6; i < args.Length; i += 2)
            {
                string partName = args[i];
                int hoursWorked = int.Parse(args[i + 1]);

                IRepairs repair = new Repair(partName, hoursWorked);
                engineer.AddRepair(repair);
            }

            return engineer;
        }

        private ISoldier GeneratePrivate(int id, string firstName, string lastName, string[] args)
        {
            ILieutenantGeneral lieutenant = new LieutenantGeneral(firstName, lastName, id, decimal.Parse(args[4]));

            for (int i = 5; i < args.Length; i++)
            {
                int privateId = int.Parse(args[i]);
                IPrivate subordinate = (IPrivate)soldiers.FirstOrDefault(x => x.Id == privateId);
                lieutenant.Privates.Add(subordinate);
            }

            return lieutenant;

        }
    }
}
