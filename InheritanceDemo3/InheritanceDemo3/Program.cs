using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo3
{
    class Bike
    {
        public void displayBikeInsurance()
        {
            Console.WriteLine("The insurance plan for the bike is 1200 per month.... ");
        }
    }
    class Car:Bike
    {
        public void displayCarInsurance()
        {
            Console.WriteLine("The insurance plan for the Car is 5000 per month.... ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.displayBikeInsurance();
            obj.displayCarInsurance();
            Console.Read();
        }
    }
}
