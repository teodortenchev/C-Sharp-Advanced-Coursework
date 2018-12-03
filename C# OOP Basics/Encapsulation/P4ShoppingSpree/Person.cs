using System;
using System.Collections.Generic;
namespace P4ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    FundsAmountException();
                }
                money = value;
            }
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


        public void BuyProduct(Product product)
        {
            if(product.Cost > Money)
            {
                throw new ArgumentException($"{Name} can't afford {product.Name}");
            }
            else
            {
                Money -= product.Cost;
                bag.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
        }

        public string ListPurchases()
        {
            if(bag.Count > 0)
            {
                string purchases = string.Join(", ", bag);
                return $"{Name} - {purchases}";
            }
            return $"{Name} - Nothing bought";
        }

       
        //Exceptions Handled Below
        private void NameException()
        {
            throw new ArgumentException("Name cannot be empty");
        }

        private void FundsAmountException()
        {
            throw new ArgumentException("Money cannot be negative");
        }
    }
}
