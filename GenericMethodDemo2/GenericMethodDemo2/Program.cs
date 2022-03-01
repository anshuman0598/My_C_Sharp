using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodDemo2
{
    internal class Program
    {
        class Swap
        {
            public void Swapping<T>(ref T a,ref T b)
            {
                T temp = a;
                a= b;
                b= temp;

            }
        }
        static void Main(string[] args)
        {
            Swap swap = new Swap();
            int a = 6, b = 8;
            double c = 7.5, d = 9.3;
            string s1 = "String 1", s2 = "String2";
            Console.WriteLine("Value of a = " + a+"\nValue of b = " + b+"\nValue of c = " + c+"\nValue of d = " + d+"\nValue of s1 = " + s1+"\nValue of s2 = "+s2);
            Console.WriteLine("--------------------------After Swapping --------------------------");
            swap.Swapping<int>(ref a,ref b);
            swap.Swapping<double>(ref c, ref d);
            swap.Swapping<string>(ref s1, ref s2);
            Console.WriteLine("Value of a = " + a + "\nValue of b = " + b + "\nValue of c = " + c + "\nValue of d = " + d + "\nValue of s1 = " + s1 + "\nValue of s2 = " + s2);
            Console.Read();
        }
    }
}
