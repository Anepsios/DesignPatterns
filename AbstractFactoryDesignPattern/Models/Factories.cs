using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Models
{
    //Concrete Factories

    //Concrete Factory
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

    //Concrete Factory
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

    //Concrete Factory
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
}
