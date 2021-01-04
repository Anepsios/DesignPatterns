using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Interfaces
{
    // Product
    interface IVehicle
    {
        int Wheels { get; set; }
        string Brand { get; set; }
    }
}
