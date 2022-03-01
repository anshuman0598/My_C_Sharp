using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLiteralsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating binary literals
            int a = 0b1010;
            //creating hexadecimal literals
            int b = 0x00A;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.Read();
        }
    }
}
