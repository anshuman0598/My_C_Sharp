using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtterSetter_Demo3
{
    class  Product

    {
        private double height;
        public double Height
        {
            get { return height + 1; }
            set { 
                    if(value < 0)
                        height = 0;
                    else
                    {
                        height = value;
                    }
                    
                }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Height = -2;
            Console.Write(product.Height);
            Console.Read();

        }
    }
}
