using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameof_Operator_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello";
            //Accessing name of variable and method
            Console.WriteLine("Variable name is : "+ nameof(name));
            Console.WriteLine("Method Name is : " + nameof(show));
            Console.Read();
        }
        static void show()
        {
            //Code Here
        }

    }
}
