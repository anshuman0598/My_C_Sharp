using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet2
{
    class Employee
    {
        private String name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "James Bond";
            Console.WriteLine("Employee name : "+emp.Name);
            Console.Read();
        }
    }
}
