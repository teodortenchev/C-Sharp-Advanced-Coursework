using System.Collections.Generic;

namespace P05_GreedyTimes
{
    public class Safe
    {

        private Queue<Item> contents;
        private static string[] rawItemData;

        public Safe(string[] rawItemData)
        {
            contents = new Queue<Item>();
            RawItemData = rawItemData;
            InitializeSafe();
        }

        public static string[] RawItemData
        {
            get { return rawItemData; }
            set { rawItemData = value; }
        }



        public Queue<Item> Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        private void InitializeSafe()
        {
            for (int i = 0; i < RawItemData.Length; i += 2)
            {
                string itemName = RawItemData[i];
                long itemCount = long.Parse(RawItemData[i + 1]);
                string itemType = GetItemType(itemName);
                Item item = new Item(itemName, itemCount, itemType);

                Contents.Enqueue(item);
            }
        }
        private static string GetItemType(string itemName)
        {
            string type = "";

            if (itemName.Length == 3)
            {
                type = "Cash";
            }
            else if (itemName.ToLower().EndsWith("gem"))
            {
                type = "Gem";
            }
            else if (itemName.ToLower() == "gold")
            {
                type = "Gold";
            }
            else
            {
                type = "Junk";
            }

            return type;
        }

        public Item PickItem()
        {
            return Contents.Dequeue();
        }
    }
}
