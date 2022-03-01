using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleClassDemo3_UsingStatic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, email) = Show();
           
            Console.WriteLine(name+"  "+ email);
            
            Console.Read();
        }
        static(string name, string email) Show()
        {
            return ("Ram", "ramcharan@gmail.com");
        }
    }
}
