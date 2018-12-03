using System;

namespace SpeedRacing
{
    class Car
    {// model, fuel amount, fuel consumption for 1 kilometer and  traveled distance
        private string model;
        private double fuelAmount;
        private double fuelPerKilometer;
        private int distanceTraveled;

        public Car (string model, double fuelAmount, double fuelPerKilomter)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKilomter = fuelPerKilomter;
            this.distanceTraveled = 0;
        }

        public int DistanceTraveled
        {
            get { return distanceTraveled; }
            set { distanceTraveled = value; }
        }

        public double FuelPerKilomter
        {
            get { return fuelPerKilometer; }
            set { fuelPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void Drive(int distanceInKm)
        {
            double fuelUsed = distanceInKm * this.FuelPerKilomter;
            if (fuelUsed <= this.FuelAmount)
            {
                this.FuelAmount -= fuelUsed;
                this.DistanceTraveled += distanceInKm;
                return;
            }
            Console.WriteLine("Insufficient fuel for the drive");
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
        }
    }
}
