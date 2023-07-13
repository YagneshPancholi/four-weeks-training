namespace VehicleManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Management System!!!");
            CarFactory cf = new CarFactory();
            TruckFactory tf = new TruckFactory();
            cf.
            List<VehicleFactory> vehicles = new List<VehicleFactory>()
            {
                new CarFactory(),
                new TruckFactory()
            };
        }
    }
    
}