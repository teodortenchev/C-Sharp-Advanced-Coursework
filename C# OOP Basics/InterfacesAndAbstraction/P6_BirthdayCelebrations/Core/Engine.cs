using System;
using System.Collections.Generic;
using System.Linq;
using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        
        private static List<ILivingBeing> livingBeings;
        private static List<Robot> robots;

        public Engine()
        {
            livingBeings = new List<ILivingBeing>();
            robots = new List<Robot>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] args = input.Split();

                if (args[0] == "Citizen")
                {
                    ILivingBeing citizen = new Citizen(args[1], int.Parse(args[2]), args[3], args[4]);
                    livingBeings.Add(citizen);
                }
                else if (args[0] == "Pet")
                {
                    ILivingBeing pet = new Pet(args[1], args[2]);
                    livingBeings.Add(pet);
                }
                else if (args[0] == "Robot")
                {
                    Robot robot = new Robot(args[1], args[2]);
                    robots.Add(robot);
                }

                input = Console.ReadLine();
            }

            string yearQuery = Console.ReadLine();

            PrintBirthdays(yearQuery);
        }

        private void PrintBirthdays(string year)
        {
            foreach (var creature in livingBeings.Where(x => x.BirthDate.EndsWith(year)))
            {
                Console.WriteLine(creature.BirthDate);
            }
        }

       
    }
}
