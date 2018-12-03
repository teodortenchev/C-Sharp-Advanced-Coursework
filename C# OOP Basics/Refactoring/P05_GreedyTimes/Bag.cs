using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class Bag
    {
        private Dictionary<string, Item> items;
        private long capacity;
        private Dictionary<string, long> typeAmounts;
        

        public Bag(long capacity)
        {
            Items = new Dictionary<string, Item>();
            Capacity = capacity;
            InitializeBag();
         }

        public Dictionary<string, Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        public Dictionary<string, long> TypeAmounts
        {
            get { return typeAmounts; }
            set { typeAmounts = value; }
        }


        private void InitializeBag()
        {
            TypeAmounts = new Dictionary<string, long>();
            TypeAmounts.Add("Gem", 0L);
            TypeAmounts.Add("Cash", 0L);
            TypeAmounts.Add("Gold", 0L);

        }

        public long Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

   

        public bool WillBeFull(long quantity)
        {
            long currentBurden = SumContents();
            return Capacity < quantity + currentBurden; 
        }

        private long SumContents()
        {
            return TypeAmounts.Sum(x => x.Value);
        }

        public void StoreItem(Item item)
        {
            if(!Items.ContainsKey(item.Name))
            {
                Items.Add(item.Name, item);
            }
            else
            {
                Items[item.Name].Quantity += item.Quantity;
            }

            TypeAmounts[item.Type] += item.Quantity;
           
        }


    }
}
