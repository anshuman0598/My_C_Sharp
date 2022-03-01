using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Filter_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            try
            {
                if (a.Length < 4)
                    throw new IndexOutOfRangeException("Array Exception Occured");
                
            }
            catch (Exception ex)when(ex.GetType().ToString()=="Array Exception Occured")
            {
                Console.WriteLine(ex.Message);

                SomeOtherTask();
            }
            Console.ReadLine();
        }
        static void SomeOtherTask()
        {
            Console.WriteLine("A new task is Executing.....");
        }
    }
}
