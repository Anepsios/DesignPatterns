using AbstractFactoryDesignPattern.Interfaces;
using AbstractFactoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    class Client
    {
        private static Client _instance;
        private IVehicleFactory _factory;

        // Singleton design pattern
        private Client()
        {
        }
        public static Client GetInstance()
        {
            if (_instance == null)
                _instance = new Client();
            return _instance;
        }

        // Using Factory Method design pattern
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

        // Using Abstract Factory design pattern
        public IVehicle GetVehicleFromFactory(int wheels, string brand)
        {
            if (brand.Equals("Toyota"))
                this._factory = new ToyotaFactory();
            else if (brand.Equals("BMW"))
                this._factory = new BMWFactory();
            else
                this._factory = new GenericFactory();
            return this._factory.GetVehicle(wheels);
        }

        public IVehicleFactory GetFactory(string brand)
        {
            if (brand.Equals("Toyota"))
                return new ToyotaFactory();
            else if (brand.Equals("BMW"))
                return new BMWFactory();
            else
                return new GenericFactory();
        }
    }
}
