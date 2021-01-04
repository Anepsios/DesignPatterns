using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Models
{
    // Concrete Products

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
