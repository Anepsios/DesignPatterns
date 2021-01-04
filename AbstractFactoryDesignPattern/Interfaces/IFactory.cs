using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Interfaces
{
    // Abstract Factory
    interface IVehicleFactory
    {
        IVehicle GetVehicle(int wheels);
    }
}
