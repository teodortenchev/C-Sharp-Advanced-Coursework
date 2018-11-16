using System;
using System.Collections.Generic;
using System.Linq;

namespace EP1KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int clipCapacity = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(GetSequence());
            Queue<int> keyholes = new Queue<int>(GetSequence());
            int intelligenceValue = int.Parse(Console.ReadLine());

            bool won = false;
            int shotsFired = 0;
            int clip = clipCapacity;

            while (bullets.Count != 0 && keyholes.Count != 0)
            {
                int currentBullet = -1;

                if (bullets.Count > 0)
                {
                    
                    currentBullet = bullets.Pop();
                    shotsFired++;
                    clip--;
 
                }

                int currentLock = -1;

                if (keyholes.Count > 0)
                {
                    currentLock = keyholes.Peek();
                }

                if (isDestroyed(currentBullet, currentLock))
                {
                    keyholes.Dequeue();
                    Console.WriteLine("Bang!");

                    if (clip <= 0 && bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        clip = clipCapacity;
                    }


                    //do we need this or can we check in the end?
                    if (keyholes.Count == 0)
                    {
                        won = true;
                        break;
                    }
                }
                else
                {
                   Console.WriteLine("Ping!");
                    if (clip <= 0 && bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        clip = clipCapacity;
                    }
                }

                
            }

            if(won)
            {
                int bulletCost = shotsFired * bulletPrice;
                int earnings = intelligenceValue - bulletCost;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnings}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {keyholes.Count}");
            }

        }

        static int[] GetSequence()
        {
            int[] sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            return sequence;
        }

        static bool isDestroyed(int bulletSize, int lockSize)
        {
            return bulletSize <= lockSize;
        }
    }
}
