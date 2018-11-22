namespace P5_MordorsCruelPlan.Foods
{
    public abstract class Food
    {
        public Food(int happiness)
        {
            this.Happiness = happiness;
        }
        public int Happiness { get; }

    }
}
