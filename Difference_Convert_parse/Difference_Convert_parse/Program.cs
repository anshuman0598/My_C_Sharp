using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Convert_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32("43");
            int y = Convert.ToInt32(null);
           // int z = int.Parse("abc");
            Console.WriteLine(x +" "+y+" ");   
        }
    }
}
