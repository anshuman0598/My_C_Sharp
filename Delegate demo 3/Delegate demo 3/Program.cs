using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo_3
{
    class Sample
    {
        public int GetSum(int a, int b, int c)
        { return a + b + c; }
    }
    internal class Program
    {
        public delegate int SampleDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            Sample s = new Sample();
            SampleDelegate sd = new SampleDelegate(s.GetSum);
            Console.WriteLine("Target Method ->  "+sd.Target);
            Console.WriteLine("Target Method Signature -> " + sd.Method);
            Console.WriteLine("Sum is " + sd.Invoke(10, 40, 89));

            Console.ReadLine();
        }
    }
}
