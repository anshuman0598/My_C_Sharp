using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo1
{
    class Sample<T>
    {
        public T value;
        public void setValue(T value)
        {
            this.value = value;

        }
        public void Display()
        {
            Console.WriteLine(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int> s = new Sample<int>();
            s.setValue(100);
            s.Display();
            Sample<String> s2 = new Sample<String>();
            s2.setValue("Hello World");
            s2.Display();
            Console.Read();

        }
    }
}
