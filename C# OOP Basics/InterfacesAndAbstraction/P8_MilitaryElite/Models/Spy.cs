using MilitaryElite.Contracts;
using System;
namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string firstName, string lastName, int id, int codeNumber) : base(firstName, lastName, id)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id}" + Environment.NewLine +
                                             $"Code Number: {CodeNumber}";
    }
}
