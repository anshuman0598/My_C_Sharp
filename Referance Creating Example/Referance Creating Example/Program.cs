using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referance_Creating_Example
{
    public class Asia
    {
        public void display ()
        {
            Console.WriteLine("This is China");
        }
    }
    class India: Asia
    {
        public new void display()
        {
            Console.WriteLine("This is India");
        }
    }
    class Westbengal : India
    {
        public new void display()
        {
            Console.WriteLine("This is West Bengal");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Westbengal obj = new Westbengal();
            obj.display();
            India obj2 = new Westbengal();
            obj2.display();
            Console.Read();
        }--------------
    }
}
