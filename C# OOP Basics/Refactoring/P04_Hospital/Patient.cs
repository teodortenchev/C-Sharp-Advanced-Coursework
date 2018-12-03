namespace P04_Hospital
{
    public class Patient
    {
        private string name;

        public Patient(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
