using System;

namespace P3_Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            private set
            {
                if (isInvalid(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        private bool isInvalid(string value)
        {
            if (value.Length < 5 || value.Length > 10)
            {
                return true;
            }

            foreach (char character in value)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return true;
                }
            }

            return false;

        }

        public override string ToString()
        {
            string lineBreak = Environment.NewLine;

            string result = $"First Name: {FirstName}" + lineBreak
                + $"Last Name: {LastName}" + lineBreak
                + $"Faculty number: {FacultyNumber}";


            return result;
        }
    }
}
