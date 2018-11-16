using System;

namespace FunctionalProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            PrintNames(names);
        
        }

        static Action<string[]> PrintNames = arr => Console.WriteLine(String.Join(Environment.NewLine, arr));

        
    }
}
