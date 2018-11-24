using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Pet : ILivingBeing
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
        public string Name { get; set; }
        public string BirthDate { get; private set; }
    }
}
