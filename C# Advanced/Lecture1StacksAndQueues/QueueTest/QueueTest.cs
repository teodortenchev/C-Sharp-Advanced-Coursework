using System;
using System.Collections.Generic;

namespace QueueTest
{
    class QueueTest
    {
        static void Main(string[] args)
        {
            char[] letters = { 'A', 'B', 'C' };
            Queue<char> testQueue = new Queue<char>(letters); //First-in, first-out

            for (int i = 0; i < 6; i++)
            {
                testQueue.Dequeue();
            }

           
        }
    }
}
