using StorageMaster.Entities.Vehicles;
using System.Linq;


namespace StorageMaster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle[] test = new Vehicle[1];
            test[0] = new Truck();

            bool hasSpace = test.Any(p => p == null);
            ;

        }
    }
}
