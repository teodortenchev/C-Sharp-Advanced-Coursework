using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string dateOne;
        private string dateTwo;

        public DateModifier()
        {
           
        }
        public string DateOne
        {
            get
            { return dateOne; }
            set
            { dateOne = value; }
        }
        public string DateTwo
        {
            get
            { return dateTwo; }
            set
            { dateTwo = value; }
        }

        public int CalculateDaysDifference(string firstDate, string secondDate)
        {
            DateTime d1 = DateTime.Parse(firstDate);
            DateTime d2 = DateTime.Parse(secondDate);
            return Math.Abs((d1 - d2).Days);
        }
    }
}
