using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    public class StartUp
    {
        static Dictionary<string, Team> teams;
        static void Main(string[] args)
        {
            teams = new Dictionary<string, Team>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] inputArgs = command.Split(";");
                string action = inputArgs[0];

                try
                {
                    if (action == "Team")
                    {
                        string name = inputArgs[1];
                        Team team = new Team(name);
                        teams.Add(name, team);
                    }
                    else if (action == "Add")
                    {
                        string teamName = inputArgs[1];
                        string playerName = inputArgs[2];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        int endurance = int.Parse(inputArgs[3]);
                        int sprint = int.Parse(inputArgs[4]);
                        int dribble = int.Parse(inputArgs[5]);
                        int passing = int.Parse(inputArgs[6]);
                        int shooting = int.Parse(inputArgs[7]);

                        Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

                        Player player = new Player(playerName, stats);
                        teams[teamName].AddPlayer(player);

                    }
                    else if (action == "Remove")
                    {
                        string teamName = inputArgs[1];
                        string playerName = inputArgs[2];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }
                        if (!teams[teamName].teamMembers.Any(p => p.Name == playerName))
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                            continue;
                        }

                        teams[teamName].RemovePlayer(teams[teamName].teamMembers.Where(p => p.Name == playerName).First());

                    }
                    else if (action == "Rating")
                    {
                        string teamName = inputArgs[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }
                        Console.WriteLine(teams[teamName]);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }


        }
    }
}
