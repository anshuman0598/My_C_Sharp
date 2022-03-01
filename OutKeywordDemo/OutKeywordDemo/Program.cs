using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeywordDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Multiplication(out x, out y);
            Console.WriteLine("Variable value = "+ x);
            Console.Read();
        }
        public static void Multiplication(out int a,out int b)
        {
            a = 40;
            b = 30;
            a *= b;

        }

    }
}
