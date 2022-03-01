using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo4
{
    class Calculation
    {
        protected void addition()
        {
            Console.WriteLine("Enter two numbers for addition:");
            int a =int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is : "+ (a+b));
        }
        protected void subtraction()
        {
            Console.WriteLine("Enter two numbers for subtraction:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The difference is : " + (a - b));

        }

    }
    class Calc : Calculation
    {
        public void addition()
        {

            base.addition();
        }
        public void subtraction()
        {
            base.subtraction();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            obj.addition();
            obj.subtraction();
            Console.Read();
        }
    }
}
