using System;

namespace P3_Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputArgs = Console.ReadLine().Split(" ");
                string firstName = inputArgs[0];
                string lasName = inputArgs[1];
                string facultyNumber = inputArgs[2];

                Student student = new Student(firstName, lasName, facultyNumber);

                inputArgs = Console.ReadLine().Split(" ");
                firstName = inputArgs[0];
                lasName = inputArgs[1];
                decimal weeklySalary = decimal.Parse(inputArgs[2]);
                double hoursPerDay = double.Parse(inputArgs[3]);

                Worker worker = new Worker(firstName, lasName, weeklySalary, hoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}

