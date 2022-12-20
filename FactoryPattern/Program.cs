namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of tires for your vehicle:");
            Console.WriteLine("4 or 2 are the choices");

            var wheelCount = int.Parse(Console.ReadLine());

           var vehicle = VehicleFactory.GetVehicle(wheelCount);

            vehicle.Drive();

        }
    }
}
