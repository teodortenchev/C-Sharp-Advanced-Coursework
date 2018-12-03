namespace CarSalesman
{
    public class Car
    {
        //    A Car has a model, engine, weight and color.An Engine has a model, 
        //    power, displacement and an efficiency. A Car’s weight and color and its Engine’s displacements 
        //    and efficiency are optional. 
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this (model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        
    }
}
