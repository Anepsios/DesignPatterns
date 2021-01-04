using AbstractFactoryDesignPattern.Interfaces;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
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

            // Singleton
            Client client = Client.GetInstance();

            // Factory Method
            IVehicle vehicle = client.GetVehicle(wheels);

            Console.WriteLine("What brand is your vehicle? (BMW/Toyota/Other)");
            string brand = Console.ReadLine();
            vehicle = client.GetVehicleFromFactory(wheels, brand);

            // Abstract Factory
            IVehicleFactory factory = client.GetFactory(brand);
            vehicle = factory.GetVehicle(wheels);
        }
    }
}
