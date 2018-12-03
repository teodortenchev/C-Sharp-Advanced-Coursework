using System;
using WildFarm.FoodItems;
using WildFarm.Models;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food CreateFood(string type, int quantity)
        {
            switch (type)
            {
                case "Fruit":
                    return new Fruit(quantity);

                case "Meat":
                    return new Meat(quantity);

                case "Seeds":
                    return new Seeds(quantity);

                case "Vegetable":
                    return new Vegetable(quantity);

                default:
                    throw new Exception("Invalid food input!");
            }
        }
    }
}
