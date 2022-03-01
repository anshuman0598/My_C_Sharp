using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Suresh");
            names.Add("Kiran");
            names.Add("Sita");
            names.Add("Ram");
            names.Add("Suresh");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
