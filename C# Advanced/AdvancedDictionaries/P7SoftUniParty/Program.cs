using System;
using System.Collections.Generic;
using System.Linq;

namespace P7SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input[0] >= 48 && input[0] <= 57)
                {
                    vips.Add(input);
                }
                else
                {
                    guests.Add(input);
                }

                input = Console.ReadLine();
            }


            input = Console.ReadLine();

            while (input != "END")
            {
                if (input[0] >= 48 && input[0] <= 57)
                {
                    vips.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }

                input = Console.ReadLine();
            }

            int noShowGuests = vips.Count + guests.Count;
            Console.WriteLine(noShowGuests);

           
                foreach (var vip in vips)
                {
                    Console.WriteLine(vip);
                }
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest);
                }
            
           


        }
    }
}
