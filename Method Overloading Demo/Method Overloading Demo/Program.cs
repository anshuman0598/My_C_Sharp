using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Demo
{
    /* public class Calc
     {
         public static int add(int a,int b)
         {
             return a + b;
         }
         public static int add(int a,int b,int c)
         {
             return a + b + c;
         }

     }
     internal class Program
     {
         static void Main(string[] args)
         {

             Console.WriteLine(Calc.add(12, 22, 32));
             Console.WriteLine(Calc.add(12, 23));

             Console.Read();
         }
     }*/
    public class Calc
    {
        public  void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public  void add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public  void add(string a, string b)
        {
            Console.WriteLine(a + " " + b);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

                Calc calc = new Calc();
                calc.add(67, 56);
                calc.add(67.3d, 45.6d);
                calc.add("Anshuman", "Das");
                Console.Read();
        }
    }

}
