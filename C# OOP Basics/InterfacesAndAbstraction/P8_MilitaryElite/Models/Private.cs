using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string firstName, string lastName, int id, decimal salary) : base(firstName, lastName, id)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";


    }
}
