using System;

namespace P1_Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                name = value;

            }
        }

        public virtual int Age
        {
            get
            {
                return age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
