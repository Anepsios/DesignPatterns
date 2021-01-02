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
            // Factory Method / Abstract Factory
            IVehicle vehicle = client.GetVehicle(wheels);
            Console.WriteLine("What brand is your vehicle? (BMW/Toyota/Generic)");
            string brand = Console.ReadLine();
            vehicle = client.GetVehicle(wheels, brand);
        }
    }

    class Client
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

        // Using Factory Method
        // class Client is my factory in this case
        public IVehicle GetVehicle(int wheels)
        {
            if (wheels == 2)
                return new Bike(wheels);
            else if (wheels == 4)
                return new Car(wheels);
            else
                return new Truck(wheels);
        }

        // Using Abstract Factory
        public IVehicle GetVehicle(int wheels, string brand)
        {
            if (brand.Equals("Toyota"))
                this._factory = new ToyotaFactory();
            else if (brand.Equals("BMW"))
                this._factory = new BMWFactory();
            else
                this._factory = new GenericFactory();
            return this._factory.GetVehicle(wheels);
        }
    }

    // Abstract Factory
    interface IVehicleFactory
    {
        IVehicle GetVehicle(int wheels);
    }

    class ToyotaFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            if (wheels == 2)
                return new Bike(wheels, "Toyota");
            else if (wheels == 4)
                return new Car(wheels, "Toyota");
            else
                return new Truck(wheels, "Toyota");
        }
    }

    class BMWFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            if (wheels == 2)
                return new Bike(wheels, "BMW");
            else if (wheels == 4)
                return new Car(wheels, "BMW");
            else
                return new Truck(wheels, "BMW");
        }
    }

    class GenericFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(int wheels)
        {
            if (wheels == 2)
                return new Bike(wheels, "Generic");
            else if (wheels == 4)
                return new Car(wheels, "Generic");
            else
                return new Truck(wheels, "Generic");
        }
    }

    // Product
    interface IVehicle
    {
        int Wheels { get; set; }
        string Brand { get; set; }
    }

    // Concrete Product
    class Car : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }


        public Car(int wheels)
        {
            this._wheels = wheels;
        }

        public Car(int wheels, string brand)
        {
            this._wheels = wheels;
            this._brand = brand;
        }
    }

    // Concrete Product
    class Bike : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public Bike(int wheels)
        {
            this._wheels = wheels;
        }

        public Bike(int wheels, string brand)
        {
            this._wheels = wheels;
            this._brand = brand;
        }
    }

    // Concrete Product
    class Truck : IVehicle
    {
        private int _wheels;

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public Truck(int wheels)
        {
            this._wheels = wheels;
        }

        public Truck(int wheels, string brand)
        {
            this._wheels = wheels;
            this._brand = brand;
        }
    }
}
