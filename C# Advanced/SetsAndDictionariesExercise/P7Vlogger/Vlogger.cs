using System;
using System.Collections.Generic;
using System.Linq;
namespace P7Vlogger
{
    class Vlogger
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> database = new Dictionary<string, int[]>();
            Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();
            HashSet<string> uniqueUsers = new HashSet<string>();
            
            string[] events = Console.ReadLine().Split();

            while (events[0] != "Statistics")
            {
                string vloggerID = events[0];
                string action = events[1];
                
                //take care if vloger db is empty
                if (action == "joined")
                {
                    if (!uniqueUsers.Contains(vloggerID))
                    {
                        database.Add(vloggerID, new int[] { 0, 0 });
                        uniqueUsers.Add(vloggerID);
                        followers[vloggerID] = new HashSet<string>();
                    }
                }
                else if (action == "followed" && uniqueUsers.Contains(vloggerID) && uniqueUsers.Contains(events[2]))
                {
                    string followedID = events[2];
                    if (followedID != vloggerID && !followers[followedID].Contains(vloggerID))
                    {
                        database[vloggerID][1]++;
                        database[followedID][0]++;
                        followers[followedID].Add(vloggerID);
                    }
                }

                events = Console.ReadLine().Split();

            }

            Console.WriteLine($"The V-Logger has a total of {uniqueUsers.Count} vloggers in its logs.");
            int iterator = 1;
            foreach (var person in database.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                string userid = person.Key;
                int followedByNumber = person.Value[0];
                int followingNumber = person.Value[1];

                Console.WriteLine($"{iterator}. {userid} : {followedByNumber} followers, {followingNumber} following");

                if (iterator == 1 && followedByNumber > 0)
                {
                    string[] followed = followers[userid].ToArray();
                    Array.Sort(followed);
                    for (int i = 0; i < followed.Length; i++)
                    {
                        Console.WriteLine($"*  {followed[i]}");
                    }
                }
                iterator++;
            }
        }
    }
}
