﻿using System.Collections.Generic;

namespace FamilyTree
{
    class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }
    
        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


    }
}
