using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of contests")
                {
                    break;
                }

                string[] input = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contestName = input[0];
                string password = input[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }


            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of submissions")
                {
                    break;
                }

                string[] input = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contestName = input[0];
                string password = input[1];
                string userName = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName] == password)
                    {
                        if (!students.ContainsKey(userName))
                        {
                            students.Add(userName, new Dictionary<string, int>());

                        }
                        if (!students[userName].ContainsKey(contestName))
                        {
                            students[userName].Add(contestName, points);
                        }
                        else if (students[userName][contestName] < points)
                        {
                            students[userName][contestName] = points;
                        }

                    }
                }


            }

            string[] bestStudentResults = FindTopStudent(students);
            var topStudent = students.OrderByDescending(x => x.Value.Sum(s => s. Value)).FirstOrDefault();
            Console.WriteLine($"Best candidate is {topStudent.Key} with total {topStudent.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var exam in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                }
            }
        }

        private static string[] FindTopStudent(Dictionary<string, Dictionary<string, int>> students)
        {
            string bestStudent = "noone";
            int mostPoints = 0;
            foreach (var student in students)
            {
                int currentPoints = 0;
                
                var exams = student.Value;

                currentPoints = exams.Sum(x => x.Value);

                if (currentPoints > mostPoints)
                {
                    mostPoints = currentPoints;
                    bestStudent = student.Key;
                }
                
            }

            string[] result = { bestStudent, mostPoints.ToString() };

            return result;
        }
    }
}
