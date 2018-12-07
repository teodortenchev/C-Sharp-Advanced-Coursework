namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        private const double HDDWeight = 1;

        public HardDrive(double price) : base(price, HDDWeight) { }
        
    }
}
