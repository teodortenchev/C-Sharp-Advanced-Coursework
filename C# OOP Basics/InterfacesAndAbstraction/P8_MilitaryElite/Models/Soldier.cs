using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private int id;

        public Soldier (string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        //TODO: Add validation
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }


        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}
