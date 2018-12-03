using System;
using System.Linq;

namespace P1P2ClassBox
{
    class StartUp
    {
        static Box box;
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                box = new Box(length, width, height);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(box.FindSurfaceArea());
            Console.WriteLine(box.FindLateralSurfaceArea());
            Console.WriteLine(box.FindVolume());

        }
    }
}
