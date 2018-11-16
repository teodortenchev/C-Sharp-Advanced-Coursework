using System;
using System.Collections.Generic;

namespace TrafficLight
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            int carsPass = int.Parse(Console.ReadLine());
            Queue<string> intersectionJam = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command != "green")
                {
                    intersectionJam.Enqueue(command);
                } else
                {
                    for (int i = 0; i < carsPass; i++)
                    {
                        if (intersectionJam.Count > 0)
                        {
                            string carName = intersectionJam.Dequeue();
                            Console.WriteLine($"{carName} passed!");
                            count++;
                        }
                        
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}
