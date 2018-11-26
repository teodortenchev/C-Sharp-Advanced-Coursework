using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
       

        public LieutenantGeneral(string firstName, string lastName, int id, decimal salary)
            : base(firstName, lastName, id, salary)
        {
            Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates { get; set; } 

     

        //TODO Does this really work?
        public override string ToString()
        {
            string firstLine = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}" + Environment.NewLine + "Privates:";
            string listPrivates = ReturnPrivates();

            return firstLine + Environment.NewLine + listPrivates;
        }

        private string ReturnPrivates()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var soldier in Privates)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
