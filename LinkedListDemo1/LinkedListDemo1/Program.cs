using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Ram");
            names.AddLast("Suresh");
            names.AddLast("Kamlesh");
            names.AddLast("Anil");
            names.AddLast("Vilam");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            LinkedListNode<string> node = names.Find("Suresh");
            names.AddBefore(node, "Sita");
            names.AddAfter(node, "Lucy");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
            //Console.Read();
        }
    }
}
