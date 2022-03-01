using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInitializeProperty_GetSet_
{
    class Program2
    {
        public string Name { get; private set; } = "Anshuman Das"; // AutoInitilize
        public int Age { get; set; } = 23;
        //Program() // Without AutoInitilize
        //{
        //    Name = "Anshuman Das";
        //}

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            p.Name = "Saikat Mondal";// Can't Change as set is private
            p.Age = 24; //  Can Change as set is public
            Console.WriteLine(p.Name);
            Console.Read();
        }
    }
}
