using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Expression_Demo1
{
    internal class Program
    {
        delegate int Square(int x);
        static void Main(string[] args)
        {
            Square GetSquare = x => x*x;
            int j = GetSquare(9);
            Console.WriteLine("Square of 9 is "+j);
            Console.Read();
        }
    }
}
