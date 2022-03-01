using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    //Super class
    class Country
    {
        protected void ShowCountry()
        {
            
            Console.WriteLine("The Country is INDIA....");

        }

    }
    // SubClass
    class State : Country
    {
        public void ShowState()
        {
            ShowCountry();
            Console.WriteLine("The State is WEST BENGAL....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            State obj = new State();
            
            obj.ShowState();
            Console.Read();
        }
    }
}
