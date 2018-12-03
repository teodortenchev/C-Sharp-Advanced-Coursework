using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];

                Employee employee = new Employee(name, salary, position, department);
                if (inputArgs.Length == 5)
                {
                    if (int.TryParse(inputArgs[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else if (inputArgs[4].Contains('@'))
                    {
                        employee.Email = inputArgs[4];
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    employee.Email = inputArgs[4];
                    employee.Age = int.Parse(inputArgs[5]);
                }

                employeesList.Add(employee); 
            }

            var topDepartment = employeesList.GroupBy(x => x.Department)
                .OrderByDescending(x => x.Average(s => s.Salary)).FirstOrDefault();
            //the key is the department ; the value is the list of employees

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (Employee employee in topDepartment.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }

        }
    }
}
