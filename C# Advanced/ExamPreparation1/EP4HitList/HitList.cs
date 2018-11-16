using System;
using System.Collections.Generic;
using System.Linq;
namespace EP4HitList
{
    class HitList
    {
        static void Main(string[] args)
        {
            int infoIndex = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> peopleData = new Dictionary<string, Dictionary<string, string>>();
            int currentInfo = 0;
            string[] killOrder = new string[2];
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end transmissions")
                {
                    killOrder = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    break;
                }
                string[] tokens = input.Split("=");
                string personsName = tokens[0];
                string[] data = tokens[1].Split(":;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Queue<string> processData = new Queue<string>(data);

                if (!peopleData.ContainsKey(personsName))
                {
                    peopleData.Add(personsName, new Dictionary<string, string>());
                }

                while (processData.Count > 0)
                {
                    string key = processData.Dequeue();
                    string value = processData.Dequeue();


                    if (!peopleData[personsName].ContainsKey(key))
                    {
                        peopleData[personsName].Add(key, value);
                    }
                    else
                    {
                        peopleData[personsName][key] = value;
                    }
                }
            }

            Dictionary<string, string> killList = peopleData[killOrder[1]];

            Console.WriteLine($"Info on {killOrder[1]}:");

            foreach (var item in killList.OrderBy(x => x.Key))
            {
                currentInfo += item.Key.Length + item.Value.Length;
                Console.WriteLine($"---{item.Key}: {item.Value}");
            }
            Console.WriteLine($"Info index: {currentInfo}");

            if (infoIndex <= currentInfo)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine("Need {0} more info.", infoIndex - currentInfo);
            }

        }
    }
}
