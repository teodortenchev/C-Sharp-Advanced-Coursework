namespace P08_PetClinics.Models
{
    public class Pet
    {
        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Kind}";
        }
    }
}
