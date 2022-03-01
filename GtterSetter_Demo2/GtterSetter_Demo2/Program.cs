using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtterSetter_Demo2
{
    class Employee
    {
        private static int counter;
        public Employee()
        {
            counter++;
        }
        public static int Counter
        {
            // get { return counter; }
            //set { counter = value; }
            get => counter;
            set => counter = value;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.Counter=10;
            Employee emp = new Employee();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Console.WriteLine(Employee.Counter);


        }
    }
}
