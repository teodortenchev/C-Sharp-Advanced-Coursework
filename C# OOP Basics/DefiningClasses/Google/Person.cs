using System;
using System.Collections.Generic;
using System.Linq;
namespace Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parents> parents;
        private List<Children> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.name = name;
            this.parents = new List<Parents>();
            this.children = new List<Children>();
            this.pokemons = new List<Pokemon>();
        }



        public void PrintResults()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Company:");
            if(this.company != null)
            {
                Console.WriteLine(this.company);
            }
            Console.WriteLine("Car:");
            if(this.car != null)
            {
                Console.WriteLine(this.car);
            }
            Console.WriteLine("Pokemon:");
            if (pokemons.Count != 0)
            {
                foreach (Pokemon pokemon in pokemons)
                {
                    Console.WriteLine(pokemon);
                }
            }
            Console.WriteLine("Parents:");
            if (parents.Count != 0)
            {
                this.parents.ForEach(x => Console.WriteLine(x));
            }
            Console.WriteLine("Children:");
            if (children.Count != 0)
            {
                this.children.ForEach(x => Console.WriteLine(x));

            }
        }


        public void AddInfo(string[] tokens, string command)
        {
            switch (command)
            {
                case "company":
                    string name = tokens[2];
                    string department = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    Company company = new Company(name, department, salary);
                    this.company = company;
                    break;
                case "pokemon":
                    string pokemonName = tokens[2];
                    string type = tokens[3];
                    Pokemon pokemon = new Pokemon(pokemonName, type);
                    this.pokemons.Add(pokemon);
                    break;
                case "parents":
                    string parentName = tokens[2];
                    string parentBirthdate = tokens[3];
                    Parents parent = new Parents(parentName, parentBirthdate);
                    this.parents.Add(parent);
                    break;
                case "children":
                    string childName = tokens[2];
                    string childBirthdate = tokens[3];
                    Children child = new Children(childName, childBirthdate);
                    this.children.Add(child);
                    break;
                case "car":
                    string model = tokens[2];
                    int carSpeed = int.Parse(tokens[3]);
                    Car car = new Car(model, carSpeed);
                    this.car = car;
                    break;

                default:
                    break;
            }
        }

        private class Company
        {
            private string name;
            private string department;
            private decimal salary;

            public Company(string name, string department, decimal salary)
            {
                this.Name = name;
                this.Department = department;
                this.Salary = salary;
            }
            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }
            public string Department
            {
                get { return department; }
                set { department = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public override string ToString()
            {
                return $"{Name} {Department} {Salary:F2}";
            }
        }
        private class Pokemon
        {
            private string name;
            private string type;

            public Pokemon(string pokemonName, string pokemonType)
            {
                this.Name = pokemonName;
                this.Type = pokemonType;
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public override string ToString()
            {
                return $"{this.Name} {this.Type}";
            }

        }
        private class Parents
        {
            private string name;
            private string birthDate;

            public Parents(string parentName, string birthDate)
            {
                this.Name = parentName;
                this.BirthDate = birthDate;
            }
            public string BirthDate
            {
                get { return birthDate; }
                set { birthDate = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public override string ToString()
            {
                return $"{this.Name} {this.BirthDate}";
            }

        }
        private class Children
        {
            private string name;
            private string birthday;

            public Children(string childName, string childBirthday)
            {
                this.Name = childName;
                this.ChildBirthday = childBirthday;
            }

            public string ChildBirthday
            {
                get { return birthday; }
                set { birthday = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public override string ToString()
            {
                return $"{this.Name} {this.ChildBirthday}";
            }
        }
        private class Car
        {
            private string model;
            private int speed;
            public Car(string model, int speed)
            {
                this.Model = model;
                this.Speed = speed;
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }


            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public override string ToString()
            {
                return $"{this.Model} {this.Speed}";
            }
        }
        
    }
}
