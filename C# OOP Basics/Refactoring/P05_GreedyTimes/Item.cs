namespace P05_GreedyTimes
{
    public class Item
    {
        private string name;
        private string type;
        private long quantity;

        public Item(string name, long quantity, string type)
        {
            Name = name;
            Quantity = quantity;
            Type = type;
        }

        public long Quantity
        {
            get { return quantity; }
            set { quantity = value; }
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

    }
}