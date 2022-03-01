using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValueDemo
{
    internal class Program
    {
        class MyClass
        {
            private int a, b;
            public void SetValues(int Firstval, int SecondVal)
            {
                a = Firstval;
                b= SecondVal;

            }
            public void ShowValue()
            {
                Console.WriteLine("The values are " + a + " and " + b);
            }
            public int GetMax()
            {
                if(a>b)
                {
                    return a;
                }
                return b;
            }
            public int GetMin()
            {
                if(a<b)
                {
                    return a;
                }
                return b;
            }
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine("Enter Two Numbers");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            myClass.SetValues(a,b);
            myClass.ShowValue();
            Console.WriteLine("Max = "+myClass.GetMax());
            Console.WriteLine("Min = " + myClass.GetMin());
            Console.Read();
        }
    }
}
