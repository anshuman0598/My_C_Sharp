using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Ram");
            names.Enqueue("Suresh");
            names.Enqueue("Anil");
            names.Enqueue("Suresh");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Elements: " + names.Peek());
            Console.WriteLine("Pop " + names.Dequeue());
            Console.WriteLine("After Pop peek Element: " + names.Peek());
            Console.Read();
        }
    }
}
