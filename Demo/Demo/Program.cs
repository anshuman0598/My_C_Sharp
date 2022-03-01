using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first condition ");
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter second condition ");
            bool c = bool.Parse(Console.ReadLine());
            bool and= b && c;
            bool or = b || c;
            bool not = !b;
            Console.WriteLine("b && c =" + and);
            Console.WriteLine("b || c =" + or);
            Console.WriteLine("!b     ="+ not);
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Preincrement" + ++a);
            Console.WriteLine("Postincrement" + a++);
            Console.WriteLine("Final Value"+a);
            Console.WriteLine("Predecrement" + --a);
            Console.WriteLine("Postdecrement" + a--);
            Console.WriteLine("Final Value" + a);

        }
    }
}
