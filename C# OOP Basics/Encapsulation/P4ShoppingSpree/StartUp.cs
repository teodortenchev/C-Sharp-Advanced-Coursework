using System;
using System.Collections.Generic;

namespace P4ShoppingSpree
{
    public class StartUp
    {
        //could have used two lists and Linq to work with    the specific people or products.
        static Dictionary<string, Person> shoppers;
        static Dictionary<string, Product> products;

        static void Main(string[] args)
        {
            string[] peopleArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            shoppers = new Dictionary<string, Person>();

            RecordShoppers(peopleArgs);

            string[] productArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            products = new Dictionary<string, Product>();

            RecordProducts(productArgs);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personsName = tokens[0];
                string productName = tokens[1];

                if (shoppers.ContainsKey(personsName) && products.ContainsKey(productName))
                {
                    Product currentProduct = products[productName];

                    try
                    {
                        shoppers[personsName].BuyProduct(currentProduct);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

            PrintShoppers();
        }

        private static void PrintShoppers()
        {
            foreach (var shopper in shoppers)
            {
                Console.WriteLine(shopper.Value.ListPurchases());
            }
        }

        public static void RecordProducts(string[] arguments)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                string[] productStats = arguments[i].Split('=');

                string name = productStats[0];
                decimal cost = decimal.Parse(productStats[1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(name, product);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public static void RecordShoppers(string[] arguments)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                string[] shopperStats = arguments[i].Split('=');

                string shoppersName = shopperStats[0];
                decimal money = decimal.Parse(shopperStats[1]);

                try
                {
                    Person shopper = new Person(shoppersName, money);
                    shoppers.Add(shopper.Name, shopper);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

            }
        }
    }
}
