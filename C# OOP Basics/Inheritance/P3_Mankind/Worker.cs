using System;

namespace P3_Mankind
{
    public class Worker : Human
    {
        private decimal weeklySalary;
        private double hoursPerDay;

        public Worker(string firstName, string lastName, decimal weeklySalary, double hoursPerDay)
            : base(firstName, lastName)
        {
            WeeklySalary = weeklySalary;
            HoursPerDay = hoursPerDay;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                weeklySalary = value;
            }
        }

        public double HoursPerDay
        {
            get
            {
                return hoursPerDay;

            }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                hoursPerDay = value;
            }
        }

        public decimal SalaryPerHour
        {
            get
            {
                return CalculatePerHour();
            }
        }

        private decimal CalculatePerHour()
        {
            return (weeklySalary / 5) / (decimal)hoursPerDay;
        }

        public override string ToString()
        {
            string lineBreak = Environment.NewLine;

            string result = $"First Name: {FirstName}" + lineBreak
                + $"Last Name: {LastName}" + lineBreak
                + $"Week Salary: {WeeklySalary:F2}" + lineBreak
                + $"Hours per day: {HoursPerDay:F2}" + lineBreak
                + $"Salary per hour: {SalaryPerHour:F2}";

            return result;
        }
    }
}
