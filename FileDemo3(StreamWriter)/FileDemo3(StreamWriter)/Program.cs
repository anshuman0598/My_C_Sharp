using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo3_StreamWriter_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Demo.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("Hello C# \nMy Name is Anshuman Das \nHow are You Doing? \nHope you are Doing Well :-)");
            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
