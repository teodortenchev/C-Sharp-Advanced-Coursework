using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Doctor> doctors = new Dictionary<string, Doctor>();
            Dictionary<string, Department> departments = new Dictionary<string, Department>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] args = command.Split();
                string departmentName = args[0];
                string doctorName = $"{args[1]} {args[2]}";
                string patientName = args[3];

                Doctor doctor = new Doctor(doctorName);
                Department department = new Department(departmentName);

                if (!doctors.ContainsKey(doctorName))
                {
                    doctors.Add(doctorName, doctor);
                }
                if (!departments.ContainsKey(departmentName))
                {
                    departments.Add(departmentName, department);
                }

                bool hasSpaceLeft = departments[departmentName].Rooms.Any(x => x.OccupiedBeds < 3);

                if (hasSpaceLeft)
                {
                    Patient patient = new Patient(patientName);

                    doctors[doctorName].AssignPatient(patient);
                    departments[departmentName].PlacePatient(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    string departmentName = args[0];
                    if (departments.ContainsKey(departmentName))
                    {
                        if (departments[departmentName].Patients.Count > 0)
                        {
                            Department department = departments[departmentName];
                            Console.Write(department);
                        }
                    }
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int roomNumber))
                {
                    string departmentName = args[0];

                    if (departments.ContainsKey(departmentName))
                    {
                        if (departments[departmentName].Patients.Count > 0 &&
                            (roomNumber > 0 && roomNumber <= 20))
                        {
                            Department department = departments[departmentName];
                            Console.Write(department.Rooms[roomNumber - 1]);
                        }
                    }
                }

                else
                {
                    string doctorName = $"{args[0]} {args[1]}";

                    if (doctors.ContainsKey(doctorName))
                    {
                        Doctor doctor = doctors[doctorName];

                        if (doctor.Patients.Count > 0)
                        {
                            foreach (var patient in doctor.Patients.OrderBy(x => x.Name))
                            {
                                Console.WriteLine(patient.Name);
                            }
                        }
                    }
                }
                //if (args.Length == 1)
                //{
                //    Console.WriteLine(string.Join("\n", departments[args[0]].Patients.Where(x => x.).SelectMany(x => x)));
                //}
                //else if (args.Length == 2 && int.TryParse(args[1], out int room))
                //{
                //    Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                //}
                //else
                //{
                //    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                //}
                command = Console.ReadLine();
            }
        }


    }
}
