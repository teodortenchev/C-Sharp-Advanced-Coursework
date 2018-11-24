using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Ferrari
{
    public class Ferrari : Car
    {
        private const string model = "488-Spider";

        public Ferrari(string driverName) : base(driverName, model)
        {
            
        }


        public override string Accelerate()
        {
            return "Zadu6avam sA!";
        }

        public override string Brake()
        {
            return "Brakes!";
        }

       
    }
}
