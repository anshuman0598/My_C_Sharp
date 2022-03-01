using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionUsingGenerics
{
    class Addition<T>
    {
        private dynamic x;
        private dynamic y;
        public void SetValues(T x, T y)
        {
            this.x = x; 
            this.y = y;
        }
        public T GetAddition()
        {
            return x + y;
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Addition<int> addition = new Addition<int>();
            addition.SetValues(89, 42);
            int sum = addition.GetAddition();
            Console.WriteLine("The sum is "+ sum);
            Console.Read();
        }
    }
}
