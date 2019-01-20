using P08_PetClinics.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace P08_PetClinics.Core
{
    public class Engine
    {
        private static List<Pet> petsDatabase;
        private static List<Clinic> clinicsDatabase;


        public Engine()
        {
            petsDatabase = new List<Pet>();
            clinicsDatabase = new List<Clinic>();
        }
        public void Run()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] args = Console.ReadLine().Split();
                string command = "";

                if (args[0] == "Create")
                {
                    if (args[1] == "Pet")
                    {
                        command = "Create Pet";
                    }
                    else if (args[1] == "Clinic")
                    {
                        command = "Create Clinic";
                    }
                }

                else
                {
                    command = args[0];
                }

                switch (command)
                {
                    case "Create Pet":
                        string name = args[2];
                        int age = int.Parse(args[3]);
                        string kind = args[4];

                        CreatePet(name, age, kind);
                        break;

                    case "Create Clinic":
                        name = args[2];
                        int roomCount = int.Parse(args[3]);

                        CreateClinic(name, roomCount);
                        break;

                    case "Add":
                        string petName = args[1];
                        string clinicName = args[2];

                        Console.WriteLine(AddPet(petName, clinicName));
                        break;

                    case "Release":
                        clinicName = args[1];

                        Console.WriteLine(Release(clinicName));
                        break;

                    case "HasEmptyRooms":
                        clinicName = args[1];

                        Console.WriteLine(HasEmptyRooms(clinicName));

                        break;

                    case "Print":
                        if (args.Length == 2)
                        {
                            clinicName = args[1];
                            Print(clinicName);
                        }
                        else
                        {
                            clinicName = args[1];
                            int roomNumber = int.Parse(args[2]);

                            Print(clinicName, roomNumber);
                        }

                        break;


                }    
            }
        }

        private void CreatePet(string name, int age, string kind)
        {
            petsDatabase.Add(new Pet(name, age, kind));
        }

        private void CreateClinic(string name, int rooms)
        {
            try
            {
                clinicsDatabase.Add(new Clinic(name, rooms));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool AddPet(string petName, string clinicName)
        {
            Pet pet = petsDatabase.First(p => p.Name == petName);
            Clinic clinic = clinicsDatabase.First(c => c.Name == clinicName);

            return clinic.AdmitPet(pet);

        }

        private bool Release(string clinicName)
        {
            Clinic clinic = clinicsDatabase.First(c => c.Name == clinicName);

            return clinic.ReleasePet();
        }

        private bool HasEmptyRooms(string clinicName)
        {
            Clinic clinic = clinicsDatabase.First(c => c.Name == clinicName);

            return clinic.HasEmptyRooms;
        }

        private void Print(string clinicName)
        {
            Clinic clinic = clinicsDatabase.First(c => c.Name == clinicName);

            Console.WriteLine(clinic);
        }

        private void Print(string clinicName, int roomNumber)
        {
            Clinic clinic = clinicsDatabase.First(c => c.Name == clinicName);

            Console.WriteLine(clinic.GetRoomContents(roomNumber - 1));
        }



    }
}
