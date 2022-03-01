using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface Vehicle
    {
        // Function that must be defined in each class that extends the interface
        double getInsuranceCost(int months);
    }
    class Car : Vehicle
    { 
        // Implementation of interface.
        public double getInsuranceCost(int months)
        {
             return 25 * months;
        }
    }
    class Bicycle : Vehicle
    {
        // Implementation of interface.
        public double getInsuranceCost(int months)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Car's Year Insurance: " + car.getInsuranceCost(12) + " $");
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("Bike's Year Insurance: " + bicycle.getInsuranceCost(12) + " $");
        }
    }
}
