using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Room
    {
        private int capacity;
        private bool isFull;
        private int occupiedBeds;
        private List<Patient> patients;

        public List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public Room()
        {
            this.Capacity = 3;
            this.IsFull = false;
            this.OccupiedBeds = 0;
            this.Patients = new List<Patient>();
        }

        public bool IsFull
        {
            get { return isFull; }
            set { isFull = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public int OccupiedBeds
        {
            get { return occupiedBeds; }
            set { occupiedBeds = value; }
        }

        public void AddPatient(Patient patient)
        {
            /*Adds patient */

            OccupiedBeds++;
            Patients.Add(patient);

            if (checkFull())
            {
                IsFull = true;
            }


        }

        private bool checkFull()
        {
            return OccupiedBeds == Capacity;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var patient in Patients.OrderBy(x => x.Name))
            {
                result += patient.Name + Environment.NewLine;
            }

            return result;
        }
    }
}
