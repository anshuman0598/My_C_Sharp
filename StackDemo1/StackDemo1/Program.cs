using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <string> names = new Stack<string>();
            names.Push("Ram");
            names.Push("Suresh");
            names.Push("Anil");
            names.Push("Suresh");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Elements: "+ names.Peek());
            Console.WriteLine("Pop "+ names.Pop());
            Console.WriteLine("After Pop peek Element: " +names.Peek());
            Console.Read();
        }
    }
}
