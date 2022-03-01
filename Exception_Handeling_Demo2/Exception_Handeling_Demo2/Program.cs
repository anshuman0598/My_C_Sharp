using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handeling_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, n2, n3;
                Console.WriteLine("Enter First Number");
                n1= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                n2= Convert.ToInt32(Console.ReadLine());
                n3 = n1 / n2;
                Console.WriteLine("The Quotient is : " + n3);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("This is OverFlow Exception");
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("This is Invalid Cast Exception");
            }
            Console.Read();  
        }
    }
}
