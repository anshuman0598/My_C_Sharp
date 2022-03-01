using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayListDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("Hiiii");
            al.Add("How Are You");
            al.Add(1000);
            al.Add(true);
            al.Add(DateTime.Now);

            Console.WriteLine(al.Count+ " values Found in the Array List");
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.Read();
        }
    }
}
