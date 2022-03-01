using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using Second;
namespace NamespaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h = new Hello();
            h.sayHello();
            Welcome w = new Welcome();
            w.SayWelcome();
            Console.ReadLine();
        }
    }
}
