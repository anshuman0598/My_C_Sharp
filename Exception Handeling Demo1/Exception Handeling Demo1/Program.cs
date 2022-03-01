using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handeling_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] s = { "Kolkata", "Bangalore", "New Delhi", "Gujarat" };
            try
            {

                Console.WriteLine(s[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Array Index Out of Range");
                Console.WriteLine(ex.Message);
            }
            try
            {
                int i = 0;
                while (true)
                {
                    Console.WriteLine(s[i]);
                    i++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("No more Element");
            }
        }
    }
}
