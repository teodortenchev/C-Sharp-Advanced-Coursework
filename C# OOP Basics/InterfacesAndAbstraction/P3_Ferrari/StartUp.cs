using System;

namespace P3_Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            IDriveable ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brake()}/{ferrari.Accelerate()}/{ferrari.Driver}");


        }
    }
}
