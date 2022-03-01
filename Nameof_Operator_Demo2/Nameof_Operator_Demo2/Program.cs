using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameof_Operator_Demo2
{
    internal class Program
    {
        int[] arr = new int[5]; 
        public static void Main(string[] args)
        {
            Program ex = new Program(); 
            try 
            { 
                ex.show(ex.arr); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
                // Displaying method name that throws the exception
                Console.WriteLine("Method name is: "+nameof(ex.show)); 
            }
            Console.Read();
        }
        int show(int[] a)
        {
            a[6] = 12; 
            return a[6];
        }

            
    }
        
    
}
