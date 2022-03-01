using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod_Demo
{
    namespace GenericMethod_Demo
    {
        class Sample
        {
            public void ReverseAndPrint<T>(T[] arr)
            {
                Array.Reverse(arr);
                foreach (T item in arr)
                    Console.Write(item + " ");
                Console.WriteLine();
            }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] intArray = { 3, 6, 2, 8, 9, 10 };
                string[] stringArray = { "Srijita", "Anshuman", "Saikat", "Himanshu" };
                double[] doubleArray = { 45.367, 76.234, 90.432, 12.345, 16.435 };
                Sample s = new Sample();
                s.ReverseAndPrint<int>(intArray);
                s.ReverseAndPrint<string>(stringArray);
                s.ReverseAndPrint<double>(doubleArray);

                Console.Read();
            }
        }
    }
}
