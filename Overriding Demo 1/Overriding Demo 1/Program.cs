using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Demo_1
{
    class US
    {
        public  virtual void ShowCountry()
        {
            Console.WriteLine("This is United States");

        }
    }
    class India : US
    {
        public  override void ShowCountry()
        {
            Console.WriteLine("This is India.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            India i = new India();
            i.ShowCountry();
            Console.Read();
        }
    }
}
