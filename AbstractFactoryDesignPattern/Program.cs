using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheels;
            string answer;
            Console.WriteLine("How many wheels does ur vehicle have? (2/4/6)");
            do
            {
                answer = Console.ReadLine();
            } while (answer != "2" && answer != "4" && answer != "6");
            wheels = Convert.ToInt32(answer);

            // Singleton Client
            Client client = Client.GetInstance();
            // Factory method / Abstract factory
            IVehicle vehicle = client.GetVehicle(wheels);
        }
    }

    class Client : IVehicleFactory
    {
        private static Client _instance;
        private IVehicleFactory _factory;
        private Client()
        {
        }

        public static Client GetInstance()
        {
            if (_instance == null)
                _instance = new Client();
            return _instance;
        }

        public IVehicle GetVehicle(int wheels)
        {
            if (wheels == 2)
                this._factory = new BikeFactory();
            else if (wheels == 4)
                this._factory = new CarFactory();
            else
                this._factory = new TruckFactory();
            return this._factory.GetVehicle(wheels);
        }
    }

    interface IVehicleFactory
    {
        IVehicle GetVehicle(int wheels);
    }

    class CarFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            return new Car(wheels);
        }
    }

    class BikeFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            return new Bike(wheels);
        }
    }

    class TruckFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            return new Truck(wheels);
        }
    }

    interface IVehicle
    {
        int Wheels { get; set; }
    }

    class Car : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        public Car(int wheels)
        {
            this._wheels = wheels;
        }
    }

    class Bike : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        public Bike(int wheels)
        {
            this._wheels = wheels;
        }
    }

    class Truck : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        public Truck(int wheels)
        {
            this._wheels = wheels;
        }
    }

}
