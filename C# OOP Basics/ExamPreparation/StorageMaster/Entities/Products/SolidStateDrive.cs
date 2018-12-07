namespace StorageMaster.Entities.Products
{
    public class SolidStateDrive : Product
    {
        private const double SSDWeight = 0.2;

        public SolidStateDrive(double price) : base(price, SSDWeight) { }

    }
}
