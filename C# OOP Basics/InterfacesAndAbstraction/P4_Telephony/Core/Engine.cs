using System;
using System.Collections.Generic;

namespace P4_Telephony.Core
{
    public class Engine
    {
        private Queue<string> numbersQueue;
        private Queue<string> websiteQueue;

        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            numbersQueue = new Queue<string>(phoneNumbers);
            websiteQueue = new Queue<string>(websites);

            Smartphone smartphone = new Smartphone();

            while (numbersQueue.Count > 0)
            {
                string number = numbersQueue.Dequeue();
                try
                {
                    smartphone.Call(number);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (websiteQueue.Count > 0)
            {
                string websiteUrl = websiteQueue.Dequeue();
                try
                {
                    smartphone.Browse(websiteUrl);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }
        }
    }
}
