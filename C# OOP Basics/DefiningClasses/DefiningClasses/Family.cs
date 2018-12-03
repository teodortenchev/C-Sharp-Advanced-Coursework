using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public List<Person> FamilyMembers
        {
            get
            {
                return familyMembers;
            }
            set
            {
                familyMembers = value;

            }
        }

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.FamilyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}