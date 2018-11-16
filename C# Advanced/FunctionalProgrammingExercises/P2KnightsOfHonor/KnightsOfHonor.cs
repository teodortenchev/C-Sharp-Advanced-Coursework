using System;
using System.Linq;
namespace P2KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().Where(x => x != string.Empty).ToArray();
            PrintKnights(names);
            
        }

        static Action<string[]> PrintKnights = names => Console.WriteLine("Sir " + String.Join(Environment.NewLine + "Sir ", names));

       
    }
}
