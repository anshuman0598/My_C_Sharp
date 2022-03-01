using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overrideing
{
    class Override
    {
        public virtual void show()
        {
            Console.WriteLine("Baseclass Show");
        }
    }
    class Override2 : Override
    {
        public override void show()
        {
            base.show();// Calling base class method
            Console.WriteLine("Sub show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Override2 over = new Override2();
            over.show();
            Console.ReadLine();
        }
    }

}
