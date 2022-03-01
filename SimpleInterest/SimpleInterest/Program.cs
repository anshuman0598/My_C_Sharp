using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principle ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            double r = double.Parse(Console.ReadLine());    
            Console.WriteLine("Enter the time");
            int t= int.Parse(Console.ReadLine());
            double i = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is : "+i);
        }
    }
}
