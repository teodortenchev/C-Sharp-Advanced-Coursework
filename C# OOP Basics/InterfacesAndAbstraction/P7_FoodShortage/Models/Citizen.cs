using FoodShortage.Contracts;

namespace FoodShortage.Models
{
    public class Citizen : IIdentifiable, ILivingBeing, IBuyer
    {
        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
            Food = 0;
        }

        public string Name { get; set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string BirthDate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
