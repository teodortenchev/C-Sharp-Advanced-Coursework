namespace P01_RawData
{
    public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo (int weight, string type)
        {
            Type = type;
            Weight = weight;
        }
    }
}
