namespace WildFarm.Models
{
    public abstract class Food
    {
        public int Quantity { get; private set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
