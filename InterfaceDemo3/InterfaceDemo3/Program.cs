using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo3
{
    interface addition
    {
        int add(int x, int y);
    }
    interface subtraction : addition
    {
        int sub(int x, int y);
    }
    interface multiplication :subtraction
    {
        int multiplication(int x, int y);
    }
    interface division : multiplication
    {
        double division(int x, int y);
    }
    public class Calculationimp :  division
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int multiplication(int x, int y)
        {
            return x * y;
        }
        public double division(int x, int y)
        {
            return x / y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculationimp calc = new Calculationimp();
            Console.WriteLine("Addition of two numbers " + calc.add(7, 8));
            Console.WriteLine("Difference of two numbers " + calc.sub(10, 4));
            Console.WriteLine("Product of two numbers " + calc.multiplication(190, 4));
            Console.WriteLine("Quotient of two numbers " + calc.division(10, 4));
            Console.Read();
        }
    }
}
