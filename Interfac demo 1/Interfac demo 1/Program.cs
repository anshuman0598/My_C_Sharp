using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_demo_1
{
    interface SimpleInterest
    {
        double GetSimpleInterest(double p, int n , double r);
    }
    class SimpleInterestImpl : SimpleInterest
    {
        public double GetSimpleInterest(double p, int n, double r)
        {
            return (p*n*r)/100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterestImpl impl = new SimpleInterestImpl();
            Console.WriteLine("Simple Interest is  : "+impl.GetSimpleInterest(20000, 3, 5));
            Console.Read();
        }
    }
}
