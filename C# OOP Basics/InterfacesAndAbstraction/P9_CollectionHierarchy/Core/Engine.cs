using CollectionHierarchy.CustomCollections;
using System;

namespace CollectionHierarchy.Core
{
    public class Engine
    {

        private static AddCollection<string> addCollection;
        private static AddRemoveCollection<string> addRemoveCollection;
        private static MyList<string> myList;

        public Engine()
        {
            addCollection = new AddCollection<string>();
            addRemoveCollection = new AddRemoveCollection<string>();
            myList = new MyList<string>();
        }

        public void Run()
        {
            string[] input = Console.ReadLine().Split();
            int removeCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(addCollection.Add(input[i]) + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(addRemoveCollection.Add(input[i]) + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(myList.Add(input[i]) + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
