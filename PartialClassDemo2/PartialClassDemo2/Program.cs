using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass s = new SampleClass();
            s.FirstMethod();
            s.SecondMethod();
            s.ThirdMethod();
            Console.Read();
        }
    }
}
