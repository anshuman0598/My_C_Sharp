using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalModifier
{
    class Sample
    {
        //read only data member
        public readonly string CompanyName = "Sample";
        //ststic data members
        public static string Location = "Mumbai";
        //static member method
        public static void ShowAddress()
        {
            Console.WriteLine("City, Mumbai.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s=new Sample();
            Console.WriteLine(s.CompanyName);
            Sample.ShowAddress();
            Console.WriteLine(Sample.Location);

            Console.Read();
        }
    }
}
