using System;

namespace P10Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] personInfo = Console.ReadLine().Split();
            string fullName = personInfo[0] + " " + personInfo[1];
            string address = personInfo[2];

            var personTuple = new SpecialTuple<string, string>(fullName, address);
            Console.WriteLine(personTuple);

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersBeer = int.Parse(secondInput[1]);

            var beerTuple = new SpecialTuple<string, int>(name, litersBeer);
            Console.WriteLine(beerTuple);

            string[] thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);

            var intDoubleTuple = new SpecialTuple<int, double>(integer, doubleNum);
            Console.WriteLine(intDoubleTuple);





        }
    }
}
