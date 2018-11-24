using System;

namespace P3_Ferrari
{
    public abstract class Car : IDriveable
    {
        public Car(string driverName, string model)
        {
            Driver = driverName;
            Model = model;
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public abstract string Accelerate();
        public abstract string Brake();
       
    }
}
