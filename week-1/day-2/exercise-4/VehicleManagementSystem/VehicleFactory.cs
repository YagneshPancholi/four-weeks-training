using System;

namespace VehicleManagementSystem {

    inteface IVehicle
    {
        void drive();
    }

    interface IRepository<T>
    {
        T getById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    public class Car : IVehicle
    {
        public int id;
        public Car(int id)
        {
            this.id = id;
        }
        public void drive()
        {
            Console.WriteLine("Driving A CAR !!!");
        }
    }
    public class Truck : IVehicle
    {
        public int id;  
        public Truck(int id)
        {
            this.id = id;
        }
        public void drive()
        {
            Console.WriteLine("Driving A TRUCK !!!");
        }
    }
    public sealed class VehicleLogger
    {
        void log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public abstract class VehicleFactory
    {
        abstract IVehicle CreateVehicle();
        void DoSomethingWithVehicle();
    }

    public static class CarFactory : VehicleFactory
    {
        public void CreateVehicle()
        {
            Car car = new Car();    
        }
    }

    public static class TruckFactory: VehicleFactory
    {
        public void CreateVehicle()
        {
            Truck truck = new Truck();
        }
    }
    

    public class VehicleRepository: IRepository
    {
        public T getById(int id)
        {
            
        }
        IEnumerable<T> GetAll()
        {

        }
        void Add(T entity)
        {

        }
        void Update(T entity)
        {

        }
        void Delete(T entity)
        {

        }
    }
    public class VehicleService
    {
        public VehicleService(VehicleRepository vr)
        {

        }
        public void AddVehicle(VehicleFactory factory)
        {
            if(factory is Car)
            {
                (Car)factory.CreateVehicle();
            }
            else
            {
                (Truck)factory.CreateVehicle();
            }
        }
        void RemoveVehicle(int id)
        {

        }
        void ListVehicles()
        {

        }
        void DoSomethingWithVehicle(int id)
        {

        }
    }
}
