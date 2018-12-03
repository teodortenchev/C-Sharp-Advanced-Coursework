using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Doctor
    {
        private string name;
        private List<Patient> patients;

        public Doctor(string name)
        {
            this.Name = name;
            Patients = new List<Patient>();
        }

        public List<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AssignPatient(Patient patient)
        {
            this.Patients.Add(patient);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var patient in Patients.OrderBy(x => x.Name))
            {
                result += patient.Name + System.Environment.NewLine;
            }

            return result;
        }
    }
}
