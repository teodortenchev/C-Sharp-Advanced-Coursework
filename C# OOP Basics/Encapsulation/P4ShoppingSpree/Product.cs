﻿using System;

namespace P4ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;


        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    NameException();
                }
                name = value;
            }
        }

        public decimal Cost
        {
            get { return cost; }
            private set
            {
                if (value < 0)
                {
                    PriceException();
                }
                    cost = value;
            }
        }


        public override string ToString()
        {
            return Name;
        }
        private void PriceException()
        {
            throw new ArgumentException("Money cannot be negative");
        }

        private void NameException()
        {
            throw new ArgumentException("Name cannot be empty");
        }

        
    }
}
