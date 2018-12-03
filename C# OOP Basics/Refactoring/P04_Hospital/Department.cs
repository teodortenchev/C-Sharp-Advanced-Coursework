using System;
using System.Collections.Generic;

namespace P04_Hospital
{
    public class Department
    {
        private string name;
        private Room[] rooms;
        private List<Patient> patients;

        public Department(string name)
        {
            this.Name = name;
            InitializeRooms();
            Patients = new List<Patient>();
        }

        public List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }



        public Room[] Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void PlacePatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.IsFull == false)
                {
                    room.AddPatient(patient);
                    Patients.Add(patient);
                    break;
                }
            }
        }

        public void InitializeRooms()
        {
            Rooms = new Room[20];
            for (int i = 0; i < 20; i++)
            {
                Rooms[i] = new Room();
            }
        }
        public override string ToString()
        {
            string result = "";
            foreach (var patient in Patients)
            {
                result += patient.Name + Environment.NewLine;
            }

            return result;
        }
    }
}
