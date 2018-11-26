using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private static List<ISoldier> soldiers;

        public Engine()
        {
            soldiers = new List<ISoldier>();
        }
        public void Run()
        {
            //            •	Private: “Private<id> < firstName > < lastName > < salary >”
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();
                string type = args[0];
                int id = int.Parse(args[1]);
                string firstName = args[2];
                string lastName = args[3];

                ISoldier soldier = null;

                if(type == "Private")
                {
                    decimal salary = decimal.Parse(args[4]);
                    soldier = new Private(firstName, lastName, id, salary);
                    Console.WriteLine(soldier);
                }
                else if (type == "LieutenantGeneral")
                {
                    soldier = GenerateLieutenant(id, firstName, lastName, args);
                    Console.WriteLine(soldier);
                }

                if(soldier != null)
                {
                    soldiers.Add(soldier);
                }

                input = Console.ReadLine();
            }

        }

        private ISoldier GenerateLieutenant(int id, string firstName, string lastName, string[] args)
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
