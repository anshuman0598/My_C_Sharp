using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMembersExample
{
    class SampleClass
    {
        public string Name { get; set;}
        //Expression Bodied Members
        public void ShowName() => Console.WriteLine(Name);

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            sc.Name = "John";
            sc.ShowName();
            Console.Read();

        }
    }
}
