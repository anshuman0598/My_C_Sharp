using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Filter_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[5];
                a[10] = 12;
            }
            catch (Exception e) when (e.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                SomeOtherTask();
            }
            void SomeOtherTask()
            {
                Console.WriteLine("A new task is executing");
            }
            Console.Read();
        }
    }
}
