using System;
using System.Linq;
using System.Collections.Generic;

namespace P6TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int totalPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalPumps; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrolPumps.Enqueue(input);
            }
            int pumpIndex = 0;
            while (true)
            {
                int fuelTank = 0;
                
                foreach (var fuelPump in petrolPumps)
                {
                    int currentFuel = fuelPump[0];
                    int distance = fuelPump[1];
                    fuelTank += currentFuel - distance;

                    if (fuelTank <0)
                    {
                        int[] tempPumpStorage = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(tempPumpStorage);
                        pumpIndex++;
                        break;
                    }

                }

                if (fuelTank >= 0)
                {
                    break;
                }

            }
            Console.WriteLine(value: pumpIndex);
        }

    }
}
