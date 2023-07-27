using System.Security.Cryptography.X509Certificates;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("How many wheels we looking for?");
                input = int.TryParse(Console.ReadLine(), out wheelCount);

            }
            while (input == false);

            var modeOfTransportation = VehicleFactory.GetVehicle(wheelCount);
            modeOfTransportation.Drive();                     
            
        }
        
    }
}
