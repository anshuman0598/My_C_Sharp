using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    public class GarbageCheck
    {
        public GarbageCheck()
        {
            Console.WriteLine("Reserve Memory");
        }

        ~GarbageCheck()
        {
            Console.WriteLine("Free Memory");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GarbageCheck g = new GarbageCheck();
            g = null;
            // free memory bt calling Garbage Collector
            GC.Collect();

            Console.Read();
        }
    }
}
