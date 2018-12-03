using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class StartUp
    {
        static Bag bag;
        static Safe safe;
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            bag = new Bag(bagCapacity);

            string[] safeContents = Console.ReadLine().Split(new char[] { ' ' },
                                            StringSplitOptions.RemoveEmptyEntries);
            safe = new Safe(safeContents);

            FillBag();
            PrintBagContents();
        }

        private static void PrintBagContents()
        {
            foreach (var itemType in bag.TypeAmounts.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key))
            {
                string categoryName = itemType.Key;
                long categoryQuantity = itemType.Value;
                if (categoryQuantity > 0)
                {
                    Console.WriteLine($"<{categoryName}> ${categoryQuantity}");
                }

                foreach (var item in bag.Items.OrderByDescending(y => y.Value.Name).ThenBy(y => y.Value.Quantity)
                                                    .Where(y => y.Value.Type == categoryName))
                {
                    Console.WriteLine($"##{item.Value.Name} - {item.Value.Quantity}");
                }
            }
        }
        public static bool EvaluateItem(Item item)
        {
            switch (item.Type)
            {
                case "Gem":

                    if (!bag.TypeAmounts.ContainsKey(item.Type))
                    {
                        if (item.Quantity > bag.TypeAmounts["Gold"])
                        {
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (item.Quantity + bag.TypeAmounts["Gem"] > bag.TypeAmounts["Gold"])
                    {
                        return false;
                    }
                    break;

                case "Cash":
                    if (!bag.TypeAmounts.ContainsKey(item.Type))
                    {
                        if (item.Quantity > bag.TypeAmounts["Gem"])
                        {
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (item.Quantity + bag.TypeAmounts["Cash"] > bag.TypeAmounts["Gem"])
                    {
                        return false;
                    }
                    break;
            }

            return true;

        }
        public static void FillBag()
        {
            while (safe.Contents.Count > 0)
            {
                Item item = safe.PickItem();

                if (item.Type != "Junk" && !bag.WillBeFull(item.Quantity))
                {
                    if (EvaluateItem(item) == true)
                    {
                        bag.StoreItem(item);
                    }
                }
            }
        }
    }
}